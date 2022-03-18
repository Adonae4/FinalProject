using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Repository;

namespace FinalProject.ConsoleApp
{
    public class UserInterface
    {
        DiaperRepository _Repo = new DiaperRepository();
        bool isRunning = true;

        public void Run()
        {
            _Repo.SeedDiaperData();

            while (isRunning)
            {
                MainMenu();


                string input = GetUserInput();

                UserInputSwitchCase(input);
            }
        }

         public void MainMenu()
        {
            Console.WriteLine("\n 1. View diaper options.\n" +
                              "2. Add diaper to list.\n" +
                              "3. Get diaper by brand name \n" +
                              "4. Exit"
            );

            Console.Write("Enter Selection: ");
            

        }
       
        private string GetUserInput()
        {
            return Console.ReadLine();
        }

        private void UserInputSwitchCase(string input)
        {
            switch (input)
            {
                case "1":
                    List<Diaper> diapers = _Repo.GetAllDiapersFromList();
                    ViewAllDiapersFromList(diapers); 
                    break;
                case "2":
                    AddDiaperToList();
                    break;
                case "3":
                    GetDiaperByBrandName();
                    break;
                    case "4":
                    Console.ReadLine();
                    isRunning= false;
                    break;
                default:
                    break;
            }
        }
        public void ViewAllDiapersFromList(List<Diaper> diapers)
        {
          foreach(var diaper in diapers){
              Console.WriteLine("");
              Console.WriteLine($"Diaper Brand: {diaper.DiaperBrandName}\n" +
            $"Overnight Compatible?: {diaper.IsOvernightCompatible} \n" +
            $"Cost per Diaper (cents): {diaper.CentPerDiaper}\n");


          }
          Console.WriteLine("Press any key to continue");
          Console.ReadLine();
        }

           //Read all
        //   public void GetAllDiapersFromList()
        // {
        //     List<Diaper> diapers = _Repo.GetAllDiapersFromList();

        //     foreach (Diaper diaper in _DiaperList)
        //     {
        //        Console.WriteLine(_DiaperList);
        //     }

        
        // }

        
        // public List<Diaper> _DiaperList = new List<Diaper>();

        // CREATE
        public void AddDiaperToList()
        {
            Diaper diaper = new Diaper();
            Console.WriteLine("Enter brand name here: \n" +
            "1. Huggies \n" +
            "2. Pampers \n" +
            "3. MamaBear \n" +
            "4. Parents Choice \n" +
            "5. Luvs \n" +
            "6. Target Brand"             
             );
           string enumInput = Console.ReadLine();

           switch(enumInput){
               case "1": 
               diaper.DiaperBrandName = DiaperBrand.Huggies;
               break;
               case "2":
                diaper.DiaperBrandName = DiaperBrand.Pampers;
               break;
               case "3": 
               diaper.DiaperBrandName = DiaperBrand.MamaBear;
               break;
               case "4": 
               diaper.DiaperBrandName = DiaperBrand.ParentsChoice;
               break;
               case "5":
                diaper.DiaperBrandName = DiaperBrand.Luvs;
               break;
               case "6": diaper.DiaperBrandName = DiaperBrand.TargetBrand;
               break;

           }
           Console.WriteLine("what is the cost per diaper (in cents)? ");
            diaper.CentPerDiaper = Int32.Parse(Console.ReadLine());

            bool overNightLoop = true;
            while(overNightLoop)
            {

            }
            Console.WriteLine("Is this diaper overnight compatible? Enter Y or N");
            string yOrN = Console.ReadLine();

            if(yOrN == "y" ||yOrN == "Y")
            {
                diaper.IsOvernightCompatible = true;
                overNightLoop = false;
            } else if (yOrN == "n" || yOrN == "N")
            {
                diaper.IsOvernightCompatible = false;
                overNightLoop = false;
            }
            else{
                Console.WriteLine("Invalid input.");
                Console.ReadLine();
            }
            Console.WriteLine("Here is Your entry, press any key to continue...");
            Console.WriteLine($"Diaper Brand: {diaper.DiaperBrandName}\n" +
            $"Overnight Compatible?: {diaper.IsOvernightCompatible} \n" +
            $"Cost per Diaper (cents): {diaper.CentPerDiaper}\n");


            Console.ReadKey();
           _Repo.AddDiaperToList(diaper);

        }       

     
        //Read one
        public Diaper GetDiaperByBrandName()
        {
            Console.WriteLine("Enter brand name here: \n" +
            "1. Huggies \n" +
            "2. Pampers \n" +
            "3. MamaBear \n" +
            "4. Parents Choice \n" +
            "5. Luvs \n" +
            "6. Target Brand"             
             );
             string brandName = Console.ReadLine();

             DiaperBrand brand = DiaperBrand.Huggies;

            switch (brandName)
            {
                case "1": 
                    brand = DiaperBrand.Huggies;
                    break;
                case "2": 
                    brand = DiaperBrand.Pampers;
                    break;
                case "3": 
                    brand = DiaperBrand.MamaBear;
                    break;
                case "4": 
                    brand = DiaperBrand.ParentsChoice;
                    break;
                case "5": 
                    brand = DiaperBrand.Luvs;
                    break;
                case "6": 
                    brand = DiaperBrand.TargetBrand;
                    break;
            }
            List<Diaper> brandDiapers = _Repo.GetDiaperByBrandName(brand);
            Console.WriteLine($"{brand}");
            foreach(var diaper in brandDiapers){
                Console.WriteLine($"Cost per diaper: {diaper.CentPerDiaper}\n" +
                $"Overnight compatible?: {diaper.IsOvernightCompatible}");
            
            }

            return null;
        }
    }  
    }
