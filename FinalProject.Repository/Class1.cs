using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Repository
{
    public enum DiaperBrand { Huggies, Pampers, MamaBear, ParentsChoice, Luvs, TargetBrand }


    public class Diaper
    {
        
        public int CentPerDiaper { get; set; }
        public DiaperBrand DiaperBrandName { get; set; }
        public bool IsOvernightCompatible { get; set; }

        public string AnnasTopChoice { get; set; }

        public Diaper(int centPerDiaper, DiaperBrand diaperBrandName, bool isOverNightCompatible, string annasTopChoice )
    {
        CentPerDiaper = centPerDiaper;
        DiaperBrandName = diaperBrandName;
        IsOvernightCompatible = IsOvernightCompatible;
        AnnasTopChoice = annasTopChoice; 

    }

    }
}
