using System;
using Xunit;
using University_Clinic_Hospital;

namespace Clinictests
{
    public class Patienttests
    {
        [Fact]
        public void Should_create_Patients() //creating instance 
        {
            //ASSERT
            Patient donald = new Patient(1, "Donald");
            //ACT
            string test_name=donald.Name;
            //assert
            Assert.Equal("Donald", test_name);

        }
        [Fact]
        public void check_blood() //HOLD change blood level 
        {

            //ARRANGE
            Patient donald = new Patient(1, "Donald");
            //ACT
            Nurse diaanna = new Nurse(11, "Dianna", false, 3);
            diaanna.Draw_Blood(donald);
            //ASSERT
            Assert.Equal(30, donald.BLOO_LEVEL);

        }

        [Fact]
         
        public void Should_change_Health_level()// Patient's  HEALTH_LEVEL  should increase
        {//ARRANGE
            Patient Danna = new Patient(1, "Danna");//HEALTH_LEVEL =10

            //ACT
            Nurse sabrina = new Nurse(12, "Sabrina", false, 43);
            sabrina.TakingCareofPatient(Danna); //Increases Patient's HEALTH_LEVEL BY 10
             
            //        ASSERT
 //           Assert.Equal(20,jessica.HEALTH_LEVEL);

        }
        [Fact]

        public void Patient_DRAW_BLOOD()// BLOOD_LEVEL 
        {//ARRANGE
            var john = new Nurse(1, "John", false, 1);
            //ACT
            Patient adam = new Patient(1, "Adam"); //BLOOD_LEVEL 20
            john.Draw_Blood(adam); //Increases BLOOD_LEVEL BY 10
            
            //        ASSERT
            Assert.Equal(30, adam.BLOO_LEVEL);

        }

    }
}
