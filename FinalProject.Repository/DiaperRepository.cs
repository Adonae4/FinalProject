using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Repository;

namespace FinalProject.Repository
{
    public class DiaperRepository
    {
       public List<Diaper> _DiaperList = new List<Diaper>();

        // CREATE object
        public void AddDiaperToList(Diaper diaper)
        {
            _DiaperList.Add(diaper);
        }

        //Read all objects
           public List<Diaper> GetAllDiapersFromList()
        {
            return _DiaperList;
        }

        //Read one object
        public Diaper GetDiaperByBrandName(string userInputBrandNameSearch)
        {
          
            return null;


        }
         public void SeedDiaperData()
        {
            Diaper Huggies = new Diaper(36, DiaperBrand.Huggies, true, "No, too expensive.");
            Diaper Pampers = new Diaper(35, DiaperBrand.Pampers, true, "No, too expensive.");
            Diaper MamaBear = new Diaper(30, DiaperBrand.MamaBear, false, "No, I buy these only whe they're on sale.");
            Diaper ParentsChoice = new Diaper(27, DiaperBrand.ParentsChoice, false, "No, these diapers are the cheapest in quality");
            Diaper Luvs = new Diaper(26, DiaperBrand.Luvs, true, "Yes");
            Diaper TargetBrand = new Diaper(17, DiaperBrand.TargetBrand, true, "Yes");


            Diaper[] diaperArr = { Huggies, Pampers, MamaBear, ParentsChoice, Luvs, TargetBrand };

            foreach (Diaper diaper in diaperArr)
            {
                AddDiaperToList(diaper);
            }
        }
    }  
    }
