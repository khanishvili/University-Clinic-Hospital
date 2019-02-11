using System;
using System.Collections.Generic;
using System.Text;

namespace University_Clinic_Hospital
{
 public   class Janitor:Employee
    {
        public bool Sweeping { get; set; }
        public Janitor(int id,string name ,bool ispaid,bool sweeping) : base(id, name,ispaid)
        {
            Sweeping = false;
            Salary = 40000;
        }

       
        public string Sweep()
        {
            if (Sweeping)
            {
               return $"{Name} just started sweeping ";
                 
            }
            else
            {
              return $"{Name} is not  sweeping";
                
            }
        }
        public void Change_status()
        {
            if (Sweeping==true)
            {
                Sweeping = false;

            }
            else if(Sweeping==false)
            {
                Sweeping = true;

            }
        }

        public override void Info()
        {
            Console.WriteLine($" \n\t Janitor {Name} {PayStatus().ToString()} . {Sweep()}");
        }
        public override string PayStatus()
        {
            return base.PayStatus();
        }
    }
}
