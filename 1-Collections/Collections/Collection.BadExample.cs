namespace Collections.BadExample;

public class CollectionsExample
{
    public List<Employee> GetEmployeesAndAlumni()
    {
        var employees = new List<Employee> {
            new() { EmployeeUuid = new Guid("{DFF3FE62-6E69-49AA-98DA-4BE98DED846C}"), FirstName = "Richard", LastName = "Crane" },
            new() { EmployeeUuid = new Guid("{41AD40ED-863A-4974-84B3-D82757517418}"), FirstName = "Scott", LastName = "Hanselman" },
            new() { EmployeeUuid = new Guid("{0F6DF452-A4BD-421E-9E39-D81AEED88BA0}"), FirstName = "Mark", LastName = "Russinovich" },
            new() { EmployeeUuid = new Guid("{3AE95631-DBFF-41D5-89EA-98039CFF483C}"), FirstName = "Dustin", LastName = "Campbell" },
            new() { EmployeeUuid = new Guid("{9A3EC6B0-08E8-4CD5-A77F-864A04070BD5}"), FirstName="Mads", LastName="Torgersen"},
            new() { EmployeeUuid = new Guid("{8B1E32BE-ED4C-4C50-B00E-D2DCFBDCFFDE}"), FirstName="James", LastName="Newton-King"}
        };

        return employees;
    }
}