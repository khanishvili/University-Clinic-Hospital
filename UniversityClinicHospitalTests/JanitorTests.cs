using System;
using Xunit;
using University_Clinic_Hospital;

namespace Clinictests
{
  public  class JanitorTests
    {
        [Fact]
        public void Should_Create_Janitors_Instance_then_Return_His_Name() 
        { 
            
            Janitor Daniel = new Janitor(12, "Daniel", false, true);

            Assert.Equal("Daniel",Daniel.Name);
        }
        [Fact]
        public void Change_Sweeping_Status_For_Janitor()
        {
            
            Janitor emp2 = new Janitor(12, "Daniel", false, true);
            
            emp2.Change_status();

            
            Assert.True(emp2.Sweeping);
        }
    }
}
