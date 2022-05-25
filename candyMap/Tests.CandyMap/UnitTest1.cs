using CandyModels;
using Xunit;

namespace Tests.CandyMap;

public class UnitTest1
{
    [Fact] //annotation states to xunit that this is a single test
    public void CreateCustomerWithDefaultValues()
    {
        //Arrange
        Customers c = new Customers();

        //Act
        //constructor actions

        //Assert
        //(expected, actual)
        Assert.Equal("", c.FirstName);
    }

    [Fact]
    public void EqualCompareDefaultCustomers()
    {
        //Arrange
        Customers c1 = new Customers();
        Customers c2 = new Customers();
        Customers c3 = c1;

        //Act
        //constructor actions

        //Assert
        Assert.Equal(c1, c3);
    }
}