using System;
using Xunit;
using University_Clinic_Hospital;

namespace Clinictests
{
    public class Nurse_test
    {
        [Fact]
        public void Should_Create_Nurse_Instance() 
        {
            //ARRANGE
            Nurse sabrina = new Nurse(12, "Sabrina", false, 43);
            //ACT
            string test_name=sabrina.Name;
            //assert
            Assert.Equal("Sabrina", test_name);

        }
        [Fact]
        public void Nurse_Gets_Paid_FiftyThousand_Per_Year()  
        {
            
            Nurse diaanna = new Nurse(11, "Dianna", false, 3);
             
            decimal salary=diaanna.Salary; 
            
            Assert.Equal(50000, salary);

        }

        [Fact]
         
        public void Should_change_Patients_Health_level_After_Nurse_Visits()
        { 
            Nurse sabrina = new Nurse(12, "Sabrina", false, 43);

            Patient jessica = new Patient(1, "Jessica");
            sabrina.TakingCareofPatient(jessica);  
             
            
            Assert.Equal(20,jessica.HEALTH_LEVEL );

        }
        [Fact]

        public void Patient_BLOOD_Level_Should_Increase_By_20() 
        { 
            var john = new Nurse(1, "John", false, 1);
            
            Patient adam = new Patient(1, "Adam"); 
            john.Draw_Blood(adam);  
            
             
            Assert.Equal(30, adam.BLOO_LEVEL);

        }

    }
}
