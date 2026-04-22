namespace zad7.Properties.Models;

public class Doctors
{
    public int IdDoctor { get; set; }
    public int IdSpecialization { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string LicenseNumber {get; set;}
    public bool IsActive { get; set; }
}