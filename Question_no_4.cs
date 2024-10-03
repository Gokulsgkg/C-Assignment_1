using System;  // Ensure this namespace is included

class Person
{
    public string name;
    public int age;
    public float weight;

    public void printPerson()
    {
        // Printing person's details
        Console.WriteLine($"Name: {name}, Age: {age}, Weight: {weight}");
    }
}

class PersonData
{
    static void Main(string[] args)
    {
        // Creating a new instance of Person and initializing fields
        Person person = new Person();
        person.name = "Kannan";
        person.age = 19;
        person.weight = 58;

        // Calling method to print details
        person.printPerson();
    }
}
