﻿using System;
using System.Collections.Generic;
using System.Text;

namespace University_Clinic_Hospital
{
 public   class Nurse : Employee
    {
        public  int  Patients { get; private set; }
        public Nurse(int emp_id, string name, bool paidstatus,int patients) : base(emp_id, name,paidstatus)
        {
            Salary = 50000;
            Patients = patients;
         }
        public override string PayStatus()
        {
            return base.PayStatus();
        }
        public override void Info()
        {             
            Console.WriteLine($"\n\t Nurse  {Name} {PayStatus().ToString()}  and takes care of {Patients} patients ");
        }  
        public void Draw_Blood(Patient temp)
        {
            temp.BLOO_LEVEL +=10;
        }
        public void TakingCareofPatient(Patient temp)
        {
            temp.HEALTH_LEVEL += 10;
        }
               
    }
}
