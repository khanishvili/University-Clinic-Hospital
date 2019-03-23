using System;

namespace University_Clinic_Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            Data clinic = new Data();
            Console.WriteLine("\n\n\n            Wellcome to University Clinic Hospital LLC Cleveland OHIO");
            while (true)
            {
                
                bool running = true;
                while (running)
                {
                   
                    Menu_Options();
                    string userInput = Console.ReadLine();                    
                    switch (userInput)
                    {
                        case "1":
                            Console.Clear();
                            clinic.Print_all_Employee();
                            break;
                        case "2": 
                            Console.Clear();
                            clinic.Print_Patients();
                            break;
                        case "3":
                            Console.Clear();
                            clinic.Print_current_info();
                            break;
                        case "4":
                            Console.Clear();
                            clinic.Print_all_Employee();
                            clinic.Search_empl_info();
                            string name = Console.ReadLine();                             
                            break;
                        case "5": 
                            clinic.Pay_everyone();
                            break;
                        case "6": 
                            clinic.Print_Patients();
                            Console.WriteLine("Type Id number  To pick patient");
                            int ID = Convert.ToInt32(Console.ReadLine());
                            clinic.Treat_Patients(clinic.Patients[ID]);
                            break; 
                        case "0": 
                            Environment.Exit(0);
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("You selected an invaild response press  0 to quit");
                            break;
                    }
                    
                   
                }
                
            }
        }
       static void Menu_Options()
        {
            Console.WriteLine("\n\t\t PLEASE  SELECT FROM THE OPTIONS BELOW \n");
            Console.WriteLine("\t\tPress 1 VIEW EMPLOYEES");
            Console.WriteLine("\t\tPress 2 To View Patients");
            Console.WriteLine("\t\tPress 3 to View Employees Current infor");
            Console.WriteLine("\t\tPress 4 to Treat Patients! ");
            Console.WriteLine("\t\tPress 5 to Pay all employee! ");
            Console.WriteLine("\t\tPress 6  to treat patient! ");

            Console.WriteLine("\t\tPress 0 to quit");
        }
    }
}
