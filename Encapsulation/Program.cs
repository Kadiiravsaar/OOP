// Eskiden encapsulation



MyClassEski m = new MyClassEski();
m.ASet(15);
Console.WriteLine(m.AGet());

Console.WriteLine("-----------------------------------------------------------------");

MyClassYeni x1 = new MyClassYeni();
x1.A = 10;
Console.WriteLine(x1.A);

class MyClassEski
{
    int a; // varsayılan olarak private olucaktır. Biz de dışarıdan erişilsin istemeyiz.

    public int AGet()
    {
        return this.a;
    }
    public void ASet(int value)
    {
        this.a = value;
    }
}




// Güncel Encapsulation 
class MyClassYeni
{
    int a;
   
    public int A
    {
        get { return a; }
        set { a = value; }
    }


}