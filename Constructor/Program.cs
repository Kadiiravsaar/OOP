// Nesne oluşturulurken, ilk ayağa kalkarken gerekli ayarlamaları yaptığımız yer.

//new MyClassConstructor("keke");
new MyClassCtorThis(5);

class MyClassConstructor
{
    public MyClassConstructor()
    {
        Console.WriteLine("Bir adet MyClass nesnesi oluşturuldu");
    }
    public MyClassConstructor(int a)
    {
        Console.WriteLine("Varsayılan Ctor'u ezdik ve sayi yazdirdik " + a);
    }
    public MyClassConstructor(string c)
    {
        Console.WriteLine("Burada yaptığım aslın da bir overload'dır");
    }
}

class MyClassCtorThis
{
    // This keywordü ile ctor'lar arası hareketlilik yapabilmekteyiz.

    public MyClassCtorThis()
    {
        Console.WriteLine("1. Constructor");
    }
    public MyClassCtorThis(int a) : this() 
    {
        Console.WriteLine("2. Constructor: " + a);
    }
    public MyClassCtorThis(int a, int b) : this(a)
    {
        Console.WriteLine("3. Constructor: " + a,b);
    }


}