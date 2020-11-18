namespace OOPracticeTest
{
    using OOPractice;
    using Xunit;

    public class CarTest
    {
        [Fact]
        public void Should_Show_Message_With_Name_And_Speed_When_Speedup()
        {
            // given
            var expectedResult = "Cool Car: speed up 30 km/h";
            var car = new Car("Cool Car", 30);

            // when
            var actual = car.SpeedUp();

            // then
            Assert.Equal(expectedResult, actual);
        }
    }

    public class TruckTest
    {
        [Fact]
        public void Should_Show_Message_With_Name_And_Speed_When_Speedup()
        {
            // given
            var expectedResult = "truck: speed up 30 km/h";
            var truck = new Truck("truck", 30);

            // when
            var actual = truck.SpeedUp();

            // then
            Assert.Equal(expectedResult, actual);
        }
    }

    public class DriverTest
    {
        [Fact]
        public void Should_Show_Message_With_Name_And_Speed_When_Speedup_Given_Drive_A_Car()
        {
            // given
            var expectedResult = "car: speed up 30 km/h";
            var driver = new Driver(new Car("car", 30));

            // when
            var actual = driver.SpeedUp();

            // then
            Assert.Equal(expectedResult, actual);
        }

        [Fact]
        public void Should_Show_Message_With_Name_And_Speed_When_Speedup_Given_Drive_A_Truck()
        {
            // given
            var expectedResult = "truck: speed up 30 km/h";
            var driver = new Driver(new Truck("truck", 30));

            // when
            var actual = driver.SpeedUp();

            // then
            Assert.Equal(expectedResult, actual);
        }
    }

    public class EngineTest
    {
        [Fact]
        public void Should_Show_Message_With_Name_And_Speed_When_Speedup_Given_Engine_A()
        {
            // given
            var expectedResult = "car: speed up 30 km/h";
            var gaslineEngine = new Gasoline();
            var car = new Car("car", gaslineEngine.GetSpeed());

            // when
            var actual = car.SpeedUp();

            // then
            Assert.Equal(expectedResult, actual);
        }
    }
}
