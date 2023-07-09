// See https://aka.ms/new-console-template for more information
using InterfaceVeAbstractDemo.Abstract;
using InterfaceVeAbstractDemo.Concrete;
using InterfaceVeAbstractDemo.Entites;

Console.WriteLine("Hello, World!");



//senaryo
// Kahve dükkanları için müşteri yönetimi yapan bir sistem
//yazmak istenmektedir.
//Starbucks ve nero firması için çalışılmaktadır.
//iki firmada müşterilerini veri tabanına kayıt etmek istemektedir.
//Starbuck müşterileri kayıdederken, mutlaka mernis numarası istemekte.
//Nero müşterileri kayıt ederken mernis numarası istememektedir.
//Starbucks her kahve alımında müşterilerine yıldız kazandırmak istemektedir.

BaseCostumerManager customerManager = new NeroCustomerManager();
customerManager.Save(new Customer { DateOfBirth = new DateTime(2000,08,24),FirstName = "Ahmet", Id = 1 , LastName = "Yakut", NationalityId = "123456"});