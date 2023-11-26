using System;

class Person
{

    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }


    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Employee : Person
{

    public string Department { get; set; }


    public Employee(string name, int age, string department)
        : base(name, age)
    {
        Department = department;
    }


    public void DisplayEmployeeInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Department: {Department}");
    }
}

class Program
{
    static void Main()
    {

        Person person = new Person("John Doe", 30);
        person.DisplayInfo();


        Employee employee = new Employee("Jane Doe", 25, "IT");
        employee.DisplayEmployeeInfo();
    }
}
