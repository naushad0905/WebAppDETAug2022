using System;
using WebAppDETAug2022.Models;
using WebAppDETAug2022.Service;

namespace TestProject_Pizza
{
    public class UnitTest1
    {
        [Fact]
        public void TestGetAllPizzas()
        {
            int expected = 2;
            int actual = PizzaService.GetAll().Count;

            Assert.Equal(expected, actual);
        }

        [Fact]

        public void Test_AddPizza()
        {
            Pizza p = new Pizza { Name = "Cheese Burst", Size = PizzaSize.Medium, IsGlutenFree = true };

            PizzaService.Add(p);

            Pizza verify = PizzaService.Get(3);

            Assert.Equal(3, PizzaService.GetAll().Count);

            Assert.NotNull(verify.Id);
        }
    }
}