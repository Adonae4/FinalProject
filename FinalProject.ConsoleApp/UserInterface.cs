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
                              "3. Get diaper by brand name"
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
                    GetAllDiapersFromList();
                    break;
                case "2":
                    AddDiaperToList();
                    break;
                case "3":
                    GetDiaperByBrandName();
                    break;
                default:
                    break;
            }
        }

           //Read all
          public void GetAllDiapersFromList()
        {
            List<Diaper> diapers = _Repo.GetAllDiapersFromList();

            foreach (Diaper diaper in _DiaperList)
            {
               return _DiaperList(diaper);
            }

        
        }

        
        public List<Diaper> _DiaperList = new List<Diaper>();

        // CREATE
        public void AddDiaperToList(Diaper Diaper)
        {
            _DiaperList.Add(Diaper);

        }
        

     
        //Read one
        public Diaper GetDiaperByBrandName();
    }  
    }
