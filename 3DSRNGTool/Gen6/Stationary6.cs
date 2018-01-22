﻿using Pk3DSRNGTool.Core;

namespace Pk3DSRNGTool
{
    public class Stationary6 : StationaryRNG
    {
        private static uint getrand => RNGPool.getrand;
        private static uint rand(uint n) => (uint)(getrand * (ulong)n >> 32);
        private static void Advance(int n) => RNGPool.Advance(n);

        public bool Bank;  // Bank = PokemonLink or Transporter
        public int Target; // Index of target pkm
        public string GenderList; // Gender list of Bank
        public bool InstantSync; // Call Sync Function once battle starts, otherwise advance 3/4 * number of party pokemon
        public bool tinysync => RNGPool.tinystatus == null ? RNGPool.AssumeSynced : RNGPool.timeline.FindFrame(RNGPool.tinystatus.Currentframe)?.sync ?? false;
        private bool getSync => AlwaysSync || tinysync;

        public override RNGResult Generate()
        {
            // Generate Pokemon before target first
            if (Bank)
                for (int i = 0; i < Target - 1; i++)
                    Generate_Once(GenderList[i]);

            Result6 rt = new Result6();
            rt.Level = Level;

            int StartFrame = RNGPool.index;

            //Sync
            rt.Synchronize = getSync;
            if (!AlwaysSync)
                Advance(60);

            //Encryption Constant
            rt.EC = getrand;

            //PID
            for (int i = PIDroll_count; i > 0; i--)
            {
                rt.PID = getrand;
                if (rt.PSV == TSV)
                {
                    if (IsShinyLocked)
                        rt.PID ^= 0x10000000;
                    else
                        rt.Shiny = true;
                    break;
                }
                else if (IsForcedShiny)
                {
                    rt.Shiny = true;
                    rt.PID = (uint)((((TSV << 4) ^ (rt.PID & 0xFFFF)) << 16) + (rt.PID & 0xFFFF)); // Not accurate
                }
            }

            //IV
            rt.IVs = (int[])IVs.Clone();
            for (int i = PerfectIVCount; i > 0;)
            {
                uint tmp = rand(6);
                if (rt.IVs[tmp] < 0)
                {
                    i--; rt.IVs[tmp] = 31;
                }
            }
            for (int i = 0; i < 6; i++)
                if (rt.IVs[i] < 0)
                    rt.IVs[i] = (int)(getrand >> 27);

            //Ability
            rt.Ability = (byte)(Ability == 0 ? (getrand >> 31) + 1 : Ability);

            //Nature
            rt.Nature = (byte)(rt.Synchronize && Synchro_Stat < 25 ? Synchro_Stat : rand(25));

            //Gender
            rt.Gender = (byte)(RandomGender ? (rand(252) >= Gender ? 1 : 2) : Gender);

            //For Pokemon Link
            rt.FrameUsed = (byte)(RNGPool.index - StartFrame);

            return rt;
        }

        private readonly static byte[] AdvanceTable = { 4, 5, 2 };
        private void Generate_Once(char gendertype) // For link/Transporter
        {
            // gendertype 0: nogender 1: randomgender 2:mew
            if (!IV3) // Johto starters
            {
                Advance(10); // EC + PID + IVs + Nature + Gender
                return;
            }
            Advance(2); // Link Legends/Transporter
            // Indefinite advance
            var IV = new bool[6];
            for (int i = gendertype == '2' ? 5 : 3; i > 0;)
            {
                uint tmp = rand(6);
                if (!IV[tmp])
                {
                    i--; IV[tmp] = true;
                }
            }
            // Random IVs, nature and probably gender
            Advance(AdvanceTable[gendertype - '0']); // 0/1/2 => 4/5/2
        }

        public override void UseTemplate(Pokemon PM)
        {
            base.UseTemplate(PM);
            var pm6 = PM as PKM6;
            InstantSync = pm6.InstantSync;
            Bank = pm6.Bank;
            if (pm6.Bank && pm6.NumOfPkm == 20 && (pm6.Species == 151 || pm6.Species == 251)) // Transporter Mystery
                PerfectIVCount = 5;
            if (pm6.OTTSV != null)
                TSV = (int)pm6.OTTSV;
        }
    }
}
