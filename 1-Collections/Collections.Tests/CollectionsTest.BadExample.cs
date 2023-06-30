using Xunit.Abstractions;

namespace Collections.BadExample.Test;

public class CollectionsTest
{
    private readonly ITestOutputHelper _testOutputHelper;

    public CollectionsTest(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void GetEmployeesAndAlumni_ReturnsEmployeesAndAlumniList()
    {
        //Arrange
        var collections = new CollectionsExample();

        //Act
        var employees = collections.GetEmployeesAndAlumni();

        for (int i = 0; i < employees.Count; i++)
        {
            var e = employees[i];
            
            _testOutputHelper.WriteLine($"{e.FirstName} {e.LastName}");
        }

        //Assert
        Assert.IsNotType<List<Employee>>(employees);
    }
}