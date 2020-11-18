namespace SET_CS
{
public class Client
{
    private string firstName;
    private string middleName;
    private string lastName;
    private System.DateTime birthDate;

    public Client(string firstName,
                  string middleName,
                  string lastName,
                  System.DateTime birthDate)
    {
        this.firstName = firstName;
        this.middleName = middleName;
        this.lastName = lastName;
        this.birthDate = birthDate;
    }

    public string GetFirstName() => firstName;
    public string GetLastName() => lastName;
    public System.DateTime GetBirthDate() => birthDate;
}
}
