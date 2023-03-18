Arac arac = new Arac();
arac.Calistir();


Arac arac2 = new Taksi();
arac2.Calistir();// Taksi Çalıştı


// Dinamik polimorfizm

class Arac
{
    virtual public void Calistir()
    {
        Console.WriteLine("Araç çalıştı");
    }
}

class Taksi : Arac
{
    public override void Calistir()
    {
        Console.WriteLine("Taksi çalıştı");
    }
}