// See https://aka.ms/new-console-template for more information
using System.Collections.Concurrent;

Console.WriteLine("Hello, World!");


Person person1 = new Person()
{
    Id = 1,
    FirstName = "Ahmet",
    LastName = "Tekgöz"
    
};

Person person2 = new Person();
person2.FirstName = "Ayşe";
//Referans tip
person1 = person2;
Console.WriteLine(person1.FirstName);

Employee employee1 = new Employee();
employee1.FirstName = "Gül";

Customer customer1 = new Customer();
customer1.FirstName = "Papatya";

//farklı sınıflar oluğu ve birbirinin base olmadıkları için convert edemeyiz
//customer1 = employee1;

person1 = employee1;
Console.WriteLine(person1.FirstName);

PersonManager personManager1 = new PersonManager();
personManager1.Add(customer1);






class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

class Employee : Person 
{
    public int EmployeeNumber { get; set; }
}

class Customer : Person
{
    public int CreditCardNumber { get; set; }
}

class PersonManager
{
    public void Add(Person person)
    {
        Console.WriteLine(person.FirstName);
    }
}