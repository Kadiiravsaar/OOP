// Bir sınıfın miras vermesini veya miras alınmasını engelleyen keeyword'dür
// Sadece sınıflarda ve sadece override edilmiş metotlarda kullanılabilir.

// isim değişikliği
Yazilimci yazilimci = new Yazilimci();
yazilimci.A(); // sealed kullandığı için muhabeseci yazacak

sealed class A
{
    // A miras vermesi engellendi
}

class B
{

}

class Calisan
{
    public virtual void A()
    {
        Console.WriteLine("Merhaba Calisan");
    }
}
class Muhasebeci : Calisan
{
    sealed public override void A()
    {
        Console.WriteLine("Merhaba Muhasebeci"); // Calisan da virtual olan metodu Muhasebe de override edilmesinde sorun yok
                                                   // fakat Yazilimci da override edilmesini istemiyorsam sealed ile işaretlenmeli
    }
}
class Yazilimci : Muhasebeci 
{
    //public override void A()
    //{
    //    Console.WriteLine("Merhaba Yazilimci");
    //}
}