class Employee
{
    private string firstName;
    private string lastName;
    private int age;
    private char gender;
    private int empID;

    public Employee(string _firstName, string _lastName, int _age, char _gender, int _empID)
    {
        if (27560000 > _empID || _empID > 27569999)
        {
            throw new ArgumentOutOfRangeException(nameof(_empID), $"Invalid employee ID, {_empID}.");
        }
        firstName = _firstName;
        lastName = _lastName;
        age = _age;
        gender = _gender;
        empID = _empID;
    }

    public void describe()
    {
        Console.WriteLine(
        "Employee Details:\n" +
        $"Name:         {firstName} {lastName}\n" + 
        $"Age:          {age}\n" +
        $"gender:       {gender.ToString().ToUpper()}\n" +
        $"Employee ID:  {empID}\n"
        );
    }

    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }
    
    public char Gender
    {
        get { return gender; }
        set { gender = value; }
    }

    public int EmpID
    {
        get { return empID; }
    }
}


