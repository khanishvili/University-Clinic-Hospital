using System;
using Xunit;
using University_Clinic_Hospital;

namespace Doctotest
{
    public class TestDoctor
    {
        [Fact]
        public void Should_return_Doctor_ID()
        {
            
            Doctor bill = new Doctor(12, "Bill", true, "Brain");
          
            int bills_ID = bill.ID;
          
            Assert.Equal(12, bills_ID);

        }
        [Fact]
        public void Specieality_Holds_value()
        {
            Doctor temp_dr = new Doctor(1, "Bill", true, "Brain");
           
            string value = temp_dr.Speciality; 
            
            Assert.Equal("Brain", value);

        }

        [Fact]
         
        public void should_Increase_Patiens_Health_Level_By_20()
        {
            Doctor temp_dr = new Doctor(1, "Bill", true, "Brain");
            
            Patient tom = new Patient(1, "Tomm");
            temp_dr.TakingCareofPatient(tom); 
             
             Assert.Equal(30, tom.HEALTH_LEVEL);

        }
        [Fact]

        public void Should_Increase_Patients_Blood_level_BY_10()  
        {
            Doctor temp_dr = new Doctor(1, "Bill", true, "Brain");
            
            Patient adam = new Patient(1, "Adam");
            temp_dr.Draw_Blood(adam);
            
           
            Assert.Equal(40, adam.BLOO_LEVEL);

        }

    }
}
