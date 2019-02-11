using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace University_Clinic_Hospital
{
    class Data
    {   
        public List<Employee> Employees { get; set; }
        public List<Patient> Patients { get; set; }
        public Data()
        {
            Employees = new List<Employee>()
        {
                new Receptionist(1,"Bill Peters",false),
                new Janitor(2,"Tommy Bush",true,false),
                new Nurse(65,"Kelly Terry",false,2),
                new Doctor(5,"Thomas Mann",true,"Brain"),
                new Doctor(13,"Greg Milik",true,"Muscle"),

        };
            Patients = new List<Patient>()
            {
                new Patient(03,"Brian"),
                new Patient(33,"David"),
                new Patient(41,"George"),
                new Patient(65,"Adam")
            };

        }
        public void Print_all_Employee()
        {


            Console.WriteLine("\t\t\t|ID|     |Name|        |Salary|    |Ispaid|    POSITION | ");
            for (int i = 0; i < Employees.Count; i++)
            {
                //Console.WriteLine($"\t\t {Employee[i].Name}  {Employee[i].ID} {Employee[i].Ispaid} ");
                Console.WriteLine("\t\t\t {0}     {1}     {2}    {3}     {4}     {5}",
                i.ToString().PadRight(2),
                Employees[i].ID.ToString().PadRight(2),
                Employees[i].Name.PadRight(10),
                Employees[i].Salary.ToString().PadRight(7),
                Employees[i].Ispaid.ToString().PadRight(5),
                 Position(i).PadRight(10)
                );
            }
        } //List of Employees
        public string Position(int i)
        {
            if (Employees[i].GetType() == typeof(Doctor))
            {
                return "Doctor";
            }
            else if (Employees[i].GetType() == typeof(Nurse))
            {
                return "Nurse";
            }
            else if (Employees[i].GetType() == typeof(Janitor))
            {
                return "Janitor";
            }
            else if (Employees[i].GetType() == typeof(Receptionist))
            {
                return "Receptionist";
            }
            return "N/A";
        } //
        public void Search_empl_info()
        {
            bool run = true;
            string input;
            while (run)
            {
                Console.Write("type name of employee make sure it will match   ");
                input = Console.ReadLine();
                int i = 0;

                do
                {

                    if (Employees[i].Name.Equals(input))
                    {
                        Employees[i].Info();
                        run = false;
                    }
                    i++;


                }
                while (i < Employees.Count);
            }
        }
        public void Print_Patients()
        {
            Console.WriteLine("\t\t\t|ID|      Patient id     |Name| |HEALTH_LEVEL| |BLOO_LEVEL|");
            for (int i = 0; i < Patients.Count; i++)
            {

                Console.WriteLine("\t\t\t {0}     {1}     {2}    {3}    {4}",
                i.ToString().PadRight(2),
                Patients[i].Patiend_id.ToString().PadRight(2),
                Patients[i].Name.PadRight(8),
                Patients[i].HEALTH_LEVEL.ToString().PadRight(7),
                Patients[i].BLOO_LEVEL.ToString().PadLeft(2)

                );
            }
        }
        public void Print_current_info()
        {
            for (int i = 0; i < Employees.Count; i++)
            {
                Employees[i].Info();
            }
        }
        public void Treat_Patients(Patient pat)
        {
            
            Console.WriteLine($"you succesfully picked Patient {pat.Name}");
            Print_all_Employee();

            Console.Write($"Please select Med ");

            int MED_ID = Convert.ToInt32(Console.ReadLine());
                Employee empl= Employees[MED_ID];
            if (empl.GetType() == typeof(Doctor))
            {
                Doctor bill = empl as Doctor;
                bill.Draw_Blood(pat);
                bill.TakingCareofPatient(pat);
                Console.WriteLine($"{pat.Name} Increased ");
            }
            else if(empl.GetType() == typeof(Nurse))
            {
                Nurse nurs = empl as Nurse;
                nurs.TakingCareofPatient(pat);
                nurs.Draw_Blood(pat);
                Console.WriteLine($"{pat.Name} Increased BLOOD LEVEL AND HEALTH TOOOO GOOD JOBB! ");
            }
            else { Console.WriteLine("Employee with this id is not qualified to treat patients please try again! or go to sleep!!"); }
        }
        public void Pay_everyone()
        {
            for(int i = 0; i < Employees.Count; i++)
            {
                Employees[i].PaySalary();
            }
            Console.WriteLine("Thank u most of our employees got paid!");
        }
      }
}
