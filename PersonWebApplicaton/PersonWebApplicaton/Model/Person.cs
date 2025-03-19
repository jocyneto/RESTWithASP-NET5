namespace PersonWebApplicaton.Model;

public class Person
{
    public long Id { get; set; }
    public string firstName { get; set; }
    public int lastNaem { get; set; }
    public DateOnly birthDate { get; set; }
    public string address { get; set; }
    public string gender { get; set; }
}
