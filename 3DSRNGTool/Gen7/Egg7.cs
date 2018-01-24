﻿using System.Linq;
using Pk3DSRNGTool.Core;

namespace Pk3DSRNGTool
{
    public class Egg7 : EggRNG
    {
        private static uint getrand => RNGPool.getrand;
        private static void Advance(int n) => RNGPool.Advance(n);

        public bool Homogeneous;
        public bool FemaleIsDitto;

        public override RNGResult Generate()
        {
            ResultE7 egg = new ResultE7();

            // Gender
            if (NidoType)
                egg.Gender = (byte)((getrand & 1) + 1);
            else
                egg.Gender = (byte)(RandomGender ? ((int)(getrand % 252) >= Gender ? 1 : 2) : Gender);

            // Nature
            egg.Nature = (byte)(getrand % 25);

            // Everstone
            // Chooses which parent if necessary;
            if (Both_Everstone)
                egg.BE_InheritParents = (getrand & 1) == 0;
            else if (EverStone)
                egg.BE_InheritParents = MaleItem == 1;

            // Ability
            egg.Ability = (byte)getRandomAbility(InheritAbility, getrand % 100);

            // PowerItem
            // Chooses which parent if necessary
            if (Both_Power)
            {
                if ((getrand & 1) == 0)
                    egg.InheritMaleIV[M_Power] = true;
                else
                    egg.InheritMaleIV[F_Power] = false;
            }
            else if (Power)
            {
                if (MaleItem > 2)
                    egg.InheritMaleIV[M_Power] = true;
                else
                    egg.InheritMaleIV[F_Power] = false;
            }

            // Inherit IV
            int tmp;
            for (int i = Power ? 1 : 0; i < InheritIVs_Cnt; i++)
            {
                do { tmp = (int)(getrand % 6); }
                while (egg.InheritMaleIV[tmp] != null);
                egg.InheritMaleIV[tmp] = (getrand & 1) == 0;
            }

            // IVs
            egg.IVs = new[] { -1, -1, -1, -1, -1, -1 };
            for (int j = 0; j < 6; j++)
            {
                egg.IVs[j] = (int)(getrand & 0x1F);
                if (egg.InheritMaleIV[j] == null) continue;
                egg.IVs[j] = (egg.InheritMaleIV[j] == true) ? MaleIVs[j] : FemaleIVs[j];
            }

            // Encryption Constant
            egg.EC = getrand;

            // PID
            for (int i = PID_Rerollcount; i > 0; i--)
            {
                egg.PID = getrand;
                if (egg.PSV == TSV) { egg.Shiny = true; break; }
            }

            // Other TSVs
            tmp = (int)egg.PSV;
            if (ConsiderOtherTSV && OtherTSVs.Contains(tmp))
                egg.Shiny = true;

            // Ball
            egg.Ball = (byte)(Homogeneous && getrand % 100 >= 50 || FemaleIsDitto ? 1 : 2);

            // Egg adopt & Egg Clear
            Advance(2);

            return egg;
        }
    }
}
