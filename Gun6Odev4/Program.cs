// See https://aka.ms/new-console-template for more information
using Gun6Odev4;

Console.WriteLine("Hello, World!");

GamerManager gamerManager = new GamerManager(new UservalidationManager());
gamerManager.Add(new Gamer
{
    BirthYear = 1985,
    FirstName = "Faruk",
    Id = 1,
    IdentityNumber = 12345,
    LastName = "YAKUT"
});
