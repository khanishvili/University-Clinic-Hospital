using System;
using System.Collections.Generic;
using System.Text;

namespace University_Clinic_Hospital
{
    class Receptionist:Employee
    {
        public bool OnthePhone { get; set; }
        public Receptionist(int emp_id, string name,bool paid) : base(emp_id, name,paid)
        {
            Salary = 45000;
            OnthePhone = false;
        }
        public override void Info()
        {
            Console.WriteLine($" \n\tReceptionist {Name} {PayStatus().ToString()}. {Name} {Avalaible().ToString()}");
        }
        public override string PayStatus()
        {
           return base.PayStatus();
        }
        public string Avalaible()
        {
            if (OnthePhone)
            {
                return " is busy on the phone and can't talk to you!!! ";
            }
            else
            {
                return " is not busy and can talk to you!";
            } 
             
        }
    }
}
