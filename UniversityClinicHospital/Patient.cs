using System;
using System.Collections.Generic;
using System.Text;

namespace University_Clinic_Hospital
{
  public  class Patient
    {
        public int Patiend_id { get; private set; }
        public string Name { get; private set; }
        public int HEALTH_LEVEL { get; set; }
        public int BLOO_LEVEL { get; set; }
        public Patient(int id ,string name)
        {
            Patiend_id = id;
            Name = name;
            HEALTH_LEVEL = 10;
            BLOO_LEVEL = 20;
        }
        public void Tick() // 
        {
            HEALTH_LEVEL -= 5;
            BLOO_LEVEL -= 5;
        }
      
    }
}
