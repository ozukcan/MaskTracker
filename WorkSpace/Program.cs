//Degiskenler();

using Business.Concrete;
using Entities.Concrete;

Person person1 = new Person();
person1.FirstName = "Engin";
person1.LastName = "Demiroğ";
person1.DateOfBirthYear = 1985;
person1.NationalIdentity = 123;

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);


static void Degiskenler()
{
    string mesaj = "Merhaba";
    double tutar = 100000; //db'den gelir
    int sayi = 100;
    bool girisYapmisMi = false;
    Console.WriteLine(tutar * 1.18);
    Console.WriteLine(tutar * 1.18);
}