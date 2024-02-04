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

