#region This

#region 1. Sınıfın Nesnesini temsil eder

class MyClassThis1
{
    public void X()
    {
        this.X(); // Baktık herhangi bir class'a this var bilmeliyiz ki o class'tan
        // üretilmiş olan nesne ne ise onu temsil etmektedir.
    }
}

#endregion


#region 2. Aynı isimde field ile metot parametrelerini ayırmak için kullanılır
class MyClassThis2
{
    int a;
    public void Y(int a)
    {
        // sadece a çağırılırsa parametre gelir
        // this.a(); fieldi temsil eder
    }
}



#endregion



#region 3. Bir Ctor'dan başka bir Ctor'u çağırmak için kullanılır


#endregion



#endregion