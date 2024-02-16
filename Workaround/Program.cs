using Business.Concrete;
using Entities.Concrete;

//Degiskenler();
//SelamVer("Fatih");
//SelamVer("Engin");
//SelamVer("Icardi");
//SelamVer();
//Topla(6,58);
//Topla();
//Diziler();
//Tipler();

Person person1 = new Person();
person1.NationalIdentity = 123;
person1.FirstName = "Fatih";
person1.LastName = "Kürekçi";
person1.DateOfBirthYear = 2002;

Person cem = new Person();
cem.FirstName = "Engin";
cem.LastName = "Demiroğ";
cem.DateOfBirthYear = 1985;
cem.NationalIdentity = 123;

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);

static void Tipler()
{
    //Referans Tipler
    string[] cities1 = { "Ankara", "İstanbul", "İzmir" };
    string[] cities2 = { "Bursa", "Antalya", "Diyarbakır" };
    cities2 = cities1;
    cities1[0] = "Adana";
    Console.WriteLine(cities2[0]); //Adana

    //Değer Tipler
    int number1 = 10;
    int number2 = 20;
    number2 = number1;
    number1 = 30;
    Console.WriteLine(number2); //10

    foreach (string city in cities1)
    {
        Console.WriteLine(city);
    }

    List<string> newcities1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
    newcities1.Add("Adana 1");
    foreach (var city in newcities1)
    {
        Console.WriteLine(city);
    }
}

static void Diziler()
{
    string[] students = new string[3];
    students[0] = "Fatih";
    students[1] = "Engin";
    students[2] = "Icardi";
    for (int i = 0; i < students.Length; i++)
    {
        Console.WriteLine(students[i]);
    }
}

static int Topla(int a = 5, int b = 10)
{
    int sonuc = a + b;
    Console.WriteLine("Toplam: " + sonuc);
    return sonuc;
}

static void SelamVer(string name = "Unknown")
{
    Console.WriteLine("Merhaba " + name);
}

static void Degiskenler()
{
    string message = "Merhaba";
    double price = 100000;
    int number = 100;
    bool isAuthenticated = false;

    string name = "Fatih";
    string surname = "Kürekçi";
    int birthYear = 2002;
    long identityNo = 123;

    Console.WriteLine(message);
    Console.WriteLine(price * 1.18);
}