using System;
using Xunit;
using University_Clinic_Hospital;

namespace Clinictests
{
  public  class JanitorTests
    {
        [Fact]
        public void should_create_instance() //
        { 
            //
            Janitor Daniel = new Janitor(12, "Daniel", false, true);

            Assert.Equal("Daniel",Daniel.Name);
        }
        [Fact]
        public void should_change_sweeping_status()
        {
            //ARRANGE
            Janitor emp2 = new Janitor(12, "Daniel", false, true);
            ////ACT
            emp2.Change_status();

            //ASSERT
            Assert.True(emp2.Sweeping);
        }
    }
}
