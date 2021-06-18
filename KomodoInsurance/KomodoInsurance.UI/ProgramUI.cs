using System;
using System.Collections.Generic;
using KomodoInsurance.Data;

namespace KomodoInsurance.UI
{
    public class ProgramUI
    {
        private readonly DeveloperRepo _devRepo = new DeveloperRepo();
        private DevTeamRepo _teamRepo = new DevTeamRepo();

        public void Run()
        {
            _devRepo.SeedContent();
            Menu();
        }
        private void Menu()
        {
            bool keepRunning = true;

            while (keepRunning)
            {


                string menu = "********************\n" +
                    "1. Create New Developer\n" +
                    "2. View Developers\n" +
                    "3. View Individual Developers\n" +
                    "4. Update Developers\n" +
                    "5. Remove Developer\n" +
                    "6. Create New Team\n" +
                    "7. View Exisiting Teams\n" +
                    "8. Sort Teams\n" +
                    "9. Update Teams\n" +
                    "10.Remove Team\n" +
                    "********************\n";
                    

                Console.WriteLine(menu);

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        CreateDeveloper();
                        break;
                    case "2":
                        ViewDevelopers();
                        break;
                    case "3":
                        ViewDeveloperByID();
                        break;
                    case "4":
                        UpdateDeveloper();
                        break;
                    case "5":
                        RemoveDeveloper();
                        break;
                    case "6":
                        CreateTeam();
                        break;
                    case "7":
                        ViewTeams();
                        break;
                    case "8":
                        ViewTeamsByName();
                        break;
                    case "9":
                        UpdateTeam();
                        break;
                    case "10":
                        RemoveTeam();
                        break;
                    case "11":
                        Console.WriteLine("Goodbye");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please Select a Menu Option");
                        break;
                    
                }
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();


            }
        }

        private void CreateDeveloper()
        {

            string name = GetAndValidateInput("Please enter the developer's First and Last name");
            bool hasPluralSight = GetAndValidateBool("Is the developer PluralSight certified? (y/n)");
            bool result = _devRepo.AddDeveloper(name, hasPluralSight);
            if(result)

            {
                Console.WriteLine("Developer has been added");
            }
            else
            {
                Console.WriteLine("Add Failed try again");
            }
        }
        private void ViewDevelopers()
        {
            Console.Clear();
            List<Developer> availableDevelopers = GetDevelopers();
            Console.WriteLine("Id \t Name");
            foreach (var developer in availableDevelopers)
            {
                Console.WriteLine($"{developer.Id}. \t {developer.Name}");
            }
        }

        private List<Developer> GetDevelopers()
        {
            throw new NotImplementedException();
        }

        private void ViewDeveloperByID()
        {
            Developer devToView = GetDeveloper();
            if (devToView == null)
            {
                Console.WriteLine("Error cannot retreieve developer");
            }
            else
            {
                Console.WriteLine("Id \t Name \t\t Is PluralSight Certified");
                Console.WriteLine($"{devToView.Id} \t {devToView.Name} \t {devToView.IsPluralSightCertified}");
            }
        }
        private Developer GetDeveloper()
        {
            Console.Clear();
            ViewDevelopers();
            int response = GetAndValidateInt("Enter developer ID number");
            Console.Clear();
            Developer devToView = _devRepo.ReturnDevelopersById(response);
            return devToView;
        }
        private void UpdateDeveloper()
        {
            Developer devToUpdate = GetDeveloper();
            Console.WriteLine($"Current Name: {devToUpdate.Name}");
            string newName = GetAndValidateInput("Enter updated name for developer");
            Console.WriteLine($"Developer currently is PluraSight certified: {devToUpdate.HasPluralSight}");
            bool newAccess = GetAndValidateBool("Are they PluralSight Certified?");
            bool response = _devRepo.UpdateDeveloper(devToUpdate.ID, newName, newAccess);
            if(response)
            {
                Console.WriteLine("Developer has been updated");
            }
            else
            {
                Console.WriteLine("Update to the developer has failed");
            }
        }
        private void RemoveDeveloper()
        {

        }
        private void CreateTeam()
        {

        }
        private void ViewTeams()
        {

        }
        private void ViewTeamsByName()
        {

        }
        private void UpdateTeam()
        {

        }
        private void RemoveTeam()
        {

        }
        private string GetAndValidateInput(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            return input;
        }
        private bool GetAndValidateBool(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine().ToLower();
            if (input == "y")
            {
                return true;
            }
            return false;
        }
        private int GetAndValidateInt(string message)
        {
            int num;
            string input;
            do
            {
                Console.WriteLine(message);
                input = Console.ReadLine();
            } while (!int.TryParse(input, out num));
            return num;
        }
    }
}
