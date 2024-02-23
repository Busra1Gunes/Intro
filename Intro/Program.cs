// See https://aka.ms/new-console-template for more information
using Intro.Business;
using Intro.Entities;

Console.WriteLine("Hello, World!");
string message1 = "Krediler";
int term = 12;
//variables=camelCase
//condition şartlar
bool isAuthenticated = false;
if (isAuthenticated)
{
    Console.WriteLine("Buton Hoşgeldiniz");
}
else
{
    Console.WriteLine("Sisteme giriş yapınız");
}
string[] krediler ={"kredi1","kredi2","kredi3","kredi4","kredi5","kredi6","kredi7"} ;
// string [] krediler=new string[6];
//krediler[0]="kredi1"
     //start      //condition        //increment
for (int i = 0; i < krediler.Length; i++)
{
    Console.WriteLine(krediler[i]);//sırasıyla 1,2,3,4,5

}
CourseManager courseManager = new();//new olduğunda coursemanager içindeki constractor çalışır
Course[] courses2= courseManager.GetAll();
for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name + " " + courses2[i].Price);

}
Console.WriteLine("Kod bitti");
IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "2314123";
customer1.FirstName = "Büşra";
customer1.LastName = "Güneş";
customer1.CustomerNumber = "3424";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "345345";
customer2.FirstName = "Kübra";
customer2.LastName = "Güneş";
customer2.CustomerNumber = "2343";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlama.io";
customer3.CustomerNumber = "2343";
customer3.TaxNumber = "1234254";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.Name = "Abc.io";
customer4.CustomerNumber = "4535";
customer4.TaxNumber = "123434534254";


BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };
//polymorphism
foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}