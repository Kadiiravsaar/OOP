// bir sınıftan nesne oluşturulurken ilk tetiklenen fonksiyon STATİC CONSTRUCTOR'DUR
// Lakin İLLKKKKKK nesne üretilirken.....

// Ctor HERRR nesne üretilirken
// Static Ctor İLKKKKK nesne üretilirken

MyClass m1 = new MyClass(); // Önce Static, Ardından normal ctor
MyClass m2 = new MyClass(); // artık Ctor
class MyClass
{
    public MyClass()
    {
        Console.WriteLine("Nesne her oluşturulurken tetiklenir");
    }
    static MyClass()
    {
        Console.WriteLine("Nesne İlk oluşturulurken tetiklenir");

    }

}