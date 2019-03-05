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
       
        public Employee(int emp_id, string name,bool paidstatus)  
        {
            ID = emp_id;
            Name = name;
            Salary = 0;
            Ispaid = paidstatus;
        }

        public abstract void Info(); 

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
                Console.WriteLine($"{Name} Just got paid!!");

            }
            else
            {
                Console.WriteLine($"{Name} We dont pay 5 time per month!!!!!! This is a Clinic not a Bank");
            }
            
        }

    
    }
}
