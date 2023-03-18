// Sanal yapılarda çağrılan member'ın hangi türe ait olduğu RUN TIME da belirlenir
// virtual ile işaretlenmiş olan metot, propety override ile illa ezilmek zorunda değildir.
// fakat bir sınıfı ezmek istiyorsak o sınıf Base class'da virtual ile işaretlenmek zorundadır.      

Terlik terlik = new Terlik();
terlik.Bilgi();

Console.WriteLine("------Yukarıda ki 1. Örnek (Satır 5 ve 6)-------");

Ucgen ucgen = new Ucgen(3, 4);
Console.WriteLine(ucgen.Hesapla()); 

#region Örnek 1
class Madde
{
    public virtual void Bilgi()
    {
        Console.WriteLine("Ben bir Maddeyim..");
    }
}

class Terlik : Madde
{
    override public void Bilgi()
    {
        Console.WriteLine("Ben bir Terliğim...");
    }
}
class Kalem : Madde
{
    override public void Bilgi()
    {
        Console.WriteLine("Ben bir Kalemim...");
    }

}
#endregion
#region Örnek 2
 
class Sekil
{
    public int _boy; // Protected de denebilirdi bu ve bundan miras alan sınıflar için. Alt satırda örnek verdim
    protected int _en;

    public Sekil(int boy, int en)
    {
        _boy = boy;
        _en = en;
    }

    virtual public int Hesapla()
    {
        return 5;

    }
}

class Ucgen : Sekil // eğer base sınıfta ctora parametre verir de burda vermezsek hata verir. Dene gör Ucgen classında ctor'a parametre verme)
{
    public Ucgen(int boy, int en) : base(boy, en)
    {

    }
    public override int Hesapla()
    {
        return _en * _boy / 2;
    }


}
class Kare : Sekil
{
    public Kare(int boy, int en) : base(boy, en)
    {

    }
    public override int Hesapla()
    {
        return (_en + _boy) *2;
    }
}


#endregion
