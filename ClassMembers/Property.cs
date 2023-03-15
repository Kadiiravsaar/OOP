// Özünde bir metottur.
// Field'lara doğrudan erişilmesini istemeyiz !!
// Field'leri kontrollü şekilde dışarı açmamızı sağlar 
// Cüzdana direk müdahale edilmesini istemeyiz örnek.

// Encapsulation => 
// Bir nesne içerisindeki dataların dışarıya kontrollü şekilde açılmasını sağlar.


class MyClassProperty
{
    int yasi;
    string b;

    // prop hangi fieldi temsil ediyorsa o türden olmasılır.

    #region Tanım
    //public int x
    //{
    //    get
    //    {
    //        return 1; // Prop çağırıldığında get tetitklenir
    //    }
    //    set
    //    {
    //        // değer atama işlemi burda yapılır
    //    }
    //}

    #endregion

    #region 
    public int Yasi
    {
        get
        {
            // prop üzerinden değer talep edildiğinde bu blok tetiklenecek
            return yasi;
        }
        set
        {
            yasi = value;
        }
    }
    #endregion

}
class PropertyBanka
{
    int bakiye;

    public int Bakiye
    {
        get
        {
            if (bakiye > 0)   
                return bakiye * 10 / 100;
            return 5;
        }
        set
        {
            if (value<10) // value demek gelen değer demek
                bakiye = value;
            
            else
                bakiye = value * 95 / 100;
        }
    }
}