
#region Bölüm 1


Yazilimci yazilimci = new Yazilimci();

Muhasebe muhasebe = new Muhasebe();
muhasebe.Musavir = true;

class Personel // Base Clas, Parent Class
{
    public string Name { get; set; }
    public string SurName { get; set; }
    public string Gender { get; set; }

}

class Muhasebe : Personel // Derived Class, Child Class

{
    public bool Musavir { get; set; }
}

class Yazilimci : Personel // Derived Class, Child Class
{

}

class Müdür : Personel // Derived Class, Child Class
{

}

class GenelMüdür : Personel  // Derived Class, Child Class
{

}

#endregion

#region Bölüm 2
// Bir sınıftan nesne üretimi yapılırken kalıtım aldığı üst sınıf varsa önce onlar üretilir.
// örn Ogul Class'ını türeticez 
// BuyukBaba() => Baba() => Ogul()

// new Ogul();

class BuyukBaba
{
    // Base Classdır
    public BuyukBaba()
    {
        Console.WriteLine("Büyük Baba sınıfı oluştu");
    }
}

class Baba : BuyukBaba
{
    // Baba Class'ının Base Class'ı BuyukBaba'dır

    // Baba Class'ının Derived Class'ı Ogul'dır
    public Baba()
    {
        Console.WriteLine("Baba sınıfı oluştu");
    }
}

class Ogul : Baba
{
    // Ogul Class'ının Base Class'ı BABA'dır
    public Ogul()
    {
        Console.WriteLine("Oğul sınıfı oluştu");
    }
}

#region Bölüm 2.2

class MyClass
{
    public MyClass(int a)
    {

    }
}

class MyClass2 : MyClass
{
    public MyClass2() : base(10) // Base Classın Ctor'una erişip değeri atadık
    {

    }

}

// Eğer ki base Classın ctor'u sadece parametre alam ctor ise dervied classlarda 
// o ctora bir değer göndermek ZORUNDAYIZ
// Bunu da BASE keyword'ü ile sağlayabiliriz.

// Base VS This keyword
// This : Bir sınıftaki ctorlar arasında geçiş yapmamızı sağlar
// Base : Bir Sınıfın base classının ctorlarından hangisinni tetikleneceğini belirmemizi sağlar

#endregion


#endregion

#region Bölüm 3
// Name Hiding
// Kalıtım durumlarında atalardaki herhangi bir member ile aynı isimde member'a sahip-
// -olan nesnelerdir

class A
{
    public void X()
    {
    }
}
class B : A
{
}
class C : B
{
}
class D : C
{
    public void X()
    {
        // Atalarda bulunan X metodu torunda da vardır buna NAME HIDING denir
        // Fakat D Class'ından bir nesne oluşturduğumuzda D Classında bulunan X metodu gelecektir.
    }
}
#endregion



