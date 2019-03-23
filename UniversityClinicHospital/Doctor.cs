using System;
using System.Collections.Generic;
using System.Text;

namespace University_Clinic_Hospital
{
   public  class Doctor:Employee
    {

        public string Speciality { get; private set; } 
        public Doctor(int emp_id, string name,bool paid,string speciality) : base(emp_id,name,paid)
        {
            Speciality = speciality;
            Salary = 90000;
        }
        public override void PaySalary()
        {
            base.PaySalary();
        } //Payyyy
        public override void Info()
        {
            Console.WriteLine($" \n\t {Speciality}  DR  {Name}'s ! {Name} {PayStatus()}");
        }   
        public override string PayStatus()    
        {
           return  base.PayStatus();
        }  

        public void Draw_Blood(Patient temp)
        {
            Console.WriteLine($"DR {Name} went to check {temp.Name}'s  blood level");
            temp.BLOO_LEVEL += 20;
        }
        public void TakingCareofPatient(Patient temp)
        {
            Console.WriteLine($"DR {Name} went to check {temp.Name}'s  health");
            temp.HEALTH_LEVEL += 20;
        }
    }
}
