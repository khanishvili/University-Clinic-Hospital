using System;
using System.Collections.Generic;
using System.Text;

namespace University_Clinic_Hospital
{
  public  abstract class Employee
    {

        //attributes for every employee
        public int ID { get;  set; }
        public string Name { get; private set;  }

        public  decimal Salary { get; set; }
        public bool Ispaid { get; private set; } 
        //
        public Employee(int emp_id, string name,bool paidstatus) // “Phil”, 111, 90000, false
        {
            ID = emp_id;
            Name = name;
            Salary = 0;
            Ispaid = paidstatus;
        }

        public abstract void Info(); //“Phil”, 111, 90000, false

        // Actions
        public virtual string PayStatus()
        {
            if (Ispaid)
            {
                return $"is Paid!!";
            }
            else
            {

                return $"is not paid";
            }
        }
        public virtual void PaySalary()
        {
            if (Ispaid == false)
            {
                Ispaid = true;
            }
            else
            {
                Console.WriteLine($"{Name} Has been Paid!!!");
            }
            
        }

        //Doctor   90,000
        //Nurse   50,000
        //Receptionist  45,000
        //Janitor 40,000
    }
}
