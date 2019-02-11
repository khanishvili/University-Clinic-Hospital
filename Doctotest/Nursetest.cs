using System;
using Xunit;
using University_Clinic_Hospital;

namespace Clinictests
{
    public class Nurse_test
    {
        [Fact]
        public void Should_create_instance() //creating instance 
        {
            //ASSERT
            Nurse sabrina = new Nurse(12, "Sabrina", false, 43);
            //ACT
            string test_name=sabrina.Name;
            //assert
            Assert.Equal("Sabrina", test_name);

        }
        [Fact]
        public void Salary_check() //Usually nurse get paid 50000
        {
            //ARRANGE
            Nurse diaanna = new Nurse(11, "Dianna", false, 3);
            //ACT
            decimal salary=diaanna.Salary; //Salary  
            //ASSERT
            Assert.Equal(50000, salary);

        }

        [Fact]
         
        public void Should_change_Health_level()// Patient's  HEALTH_LEVEL  should increase
        {//ARRANGE
            Nurse sabrina = new Nurse(12, "Sabrina", false, 43);
            //ACT
            Patient jessica = new Patient(1, "Jessica");//HEALTH_LEVEL =10
            sabrina.TakingCareofPatient(jessica); //Increases Patient's HEALTH_LEVEL BY 10
             
            //        ASSERT
            Assert.Equal(20,jessica.HEALTH_LEVEL );

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
