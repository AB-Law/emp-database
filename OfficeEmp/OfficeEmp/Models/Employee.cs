using System.ComponentModel.DataAnnotations;

namespace OfficeEMP.Models;

public class Employee
{
    public int Id { get; set; }
    public string? Name { get; set; }
    [DataType(DataType.Date)]
    public DateTime JoinDate { get; set; }
    public string? Department { get; set; }
    public decimal Salary { get; set; }
}