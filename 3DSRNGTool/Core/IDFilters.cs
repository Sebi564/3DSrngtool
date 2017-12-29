﻿using System.Linq;

namespace Pk3DSRNGTool.Core
{
    internal class IDFilters
    {
        public byte IDType;
        public bool Skip, RE;
        public string[] IDList;
        public string[] TSVList;
        public string[] RandList;

        private bool CheckID(IDResult ID)
        {
            switch (IDType)
            {
                case 0: return CheckID(string.Format("{0:D5}", ID.TID));
                case 1: return CheckID(string.Format("{0:D5}", ID.SID));
                case 2: return CheckID(string.Format("{0:D6}", (ID as ID7).G7TID));
                default: return false;
            }
        }

        private bool CheckID(string ID)
        {
            if (RE)
                return IDList.Any(id => System.Text.RegularExpressions.Regex.IsMatch(ID, id));
            return IDList.Any(id => id != "" && ID.IndexOf(id, System.StringComparison.Ordinal) >= 0);
        }

        private bool CheckTSV(IDResult ID)
        {
            ushort TSV = ID.TSV;
            for (int i = 0; i < TSVList.Length; i++)
            {
                if (!int.TryParse(TSVList[i], out int val))
                    continue;

                if (0 > val || val > 4095)
                    continue;

                if (val == TSV)
                    return true;
            }
            return false;
        }

        private bool CheckRand(IDResult ID)
        {
            string Randstr = (ID as ID6)?.Status.ToString() ?? (ID as ID7)?.RandNum.ToString("X16");
            if (RE)
                return RandList.Any(rand => System.Text.RegularExpressions.Regex.IsMatch(Randstr, rand));
            return RandList.Any(rand => rand != "" && Randstr.IndexOf(rand.ToUpper(), System.StringComparison.Ordinal) >= 0);
        }

        public bool CheckResult(IDResult ID)
        {
            if (Skip)
                return true;
            if (IDList.Length != 0 && !CheckID(ID))
                return false;
            if (TSVList.Length != 0 && !CheckTSV(ID))
                return false;
            if (RandList.Length != 0 && !CheckRand(ID))
                return false;
            return true;
        }
    }
}
