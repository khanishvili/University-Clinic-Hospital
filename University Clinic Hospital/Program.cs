﻿using System;

namespace University_Clinic_Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            Data clinic = new Data();
            
            while (true)
            {
                Console.WriteLine("wellcome to University Clinic Hospital LLC Cleveland OHIO");
                Console.WriteLine("PLease choose ");
                Console.WriteLine("\n\t\t PLEASE  SELECT FROM THE OPTIONS BELOW \n");
                Console.WriteLine("\t\tPress 1 VIEW EMPLOYEES");
                Console.WriteLine("\t\tPress 2 to view Patients");
                Console.WriteLine("\t\tPress 3 to Treat Patients! ");
                
                Console.WriteLine("\t\tPress 0 to quit");
                bool running = true;

                while (running)
                {
                   
                    string userInput = Console.ReadLine();
                    
                    switch (userInput)
                    {
                        case "1"://EMPL
                            clinic.Print_all_Employee();
                            break;
                        case "2"://View patients
                            clinic.Print_Patients();
                            break;
                        case "3": // Treat Patient!!!!
                            clinic.Treat_Patients();
                            break;
                        case "4":  //  Select Emp infor with name!
                            clinic.Print_all_Employee();
                            clinic.Search_empl_info();
                            string name = Console.ReadLine();
                             
                            break;
                        case "5": //

                            break;
                        case "6"://

                            break;
                        case "7": //

                            break;
                        case "0"://Close the program
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("You selected an invaild response press  0 to quit");
                            break;
                    }
                }
            }
        }
    }
}