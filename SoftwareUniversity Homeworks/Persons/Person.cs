using System;

class Person
{
    public Person(string name, byte age, string email)
    {
        this.Name = name;
        this.Age = age;
        this.Email = email;
    }
    public Person(string name, byte age)
        : this(name, age, null)
    {
    }
    private string name;
    private byte age;
    private string email;

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name cannot be empty.");
            }
            else
            {
                this.name = value;
            }
        }
    }
    public byte Age
    {
        get
        {
            return age;
        }
        set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentOutOfRangeException("Age should be in the interval [0;100]");
            }
            else
            {
                this.age = value;
            }
        }
    }
    public string Email
    {
        get
        {
            return email;
        }
        set
        {
            if (value == "" || (value!=null && !value.Contains("@")))
            {
                throw new ArgumentException("Not a valid email. Email should either be null or a non-empty string containing @.");
            }
            else
            {
                this.email = value;
            }
        }
    }

    public override string ToString()
    {
        string info = "Person Info:" + "\nName: " + Name + "\nAge: " + Age;
        if (!String.IsNullOrEmpty(Email))
        {
            info += "\nEmail: " + Email;
        }
        return info;
    }

}