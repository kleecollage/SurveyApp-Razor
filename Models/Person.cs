namespace EncuestaRazor.Models;

public enum DocumentState
{
    Initiated = 1,
    UnderReview = 2,
    Rejected = 3,
    Cancelled = 4,
    Approved = 5,
}
public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
}