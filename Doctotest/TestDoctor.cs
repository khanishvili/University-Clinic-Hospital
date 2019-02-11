using System;
using Xunit;
using University_Clinic_Hospital;

namespace Doctotest
{
    public class TestDoctor
    {
        [Fact]
        public void Should_return_ID() //creating instance 
        {
            //ASSERT
            Doctor bill = new Doctor(12, "Bill", true, "Brain");
            //ACT
            int bills_ID = bill.ID;
            //assert
            Assert.Equal(12, bills_ID);

        }
        [Fact]
        public void Specieality_Holds_value()
        {//ARRANGE
            Doctor temp_dr = new Doctor(1, "Bill", true, "Brain");
            //ACT
            string value = temp_dr.Speciality; //actual value
            //        ASSERT
            Assert.Equal("Brain", value);

        }

        [Fact]
         
        public void should_takecareofPatient()// HEALTH_LEVEL
        {//ARRANGE
            Doctor temp_dr = new Doctor(1, "Bill", true, "Brain");
            //ACT
            Patient tom = new Patient(1, "Tomm");
            temp_dr.TakingCareofPatient(tom); //Increases Patient's HEALTH_LEVEL BY 20
             
            //        ASSERT
            Assert.Equal(30, tom.HEALTH_LEVEL);

        }
        [Fact]

        public void Shoul_change_Patients_Blood_level()// BLOOD_LEVEL 
        {//ARRANGE
            Doctor temp_dr = new Doctor(1, "Bill", true, "Brain");
            //ACT
            Patient adam = new Patient(1, "Adam");
            temp_dr.Draw_Blood(adam); //Increases BLOOD_LEVEL
            
            //        ASSERT
            Assert.Equal(40, adam.BLOO_LEVEL);

        }

    }
}
