// Abstract Classlar soyut yapılanmalar olduğu için iradeli bir şekilde (new ile ) bir nesne üretilmez.
// kalıtımsal olarak bir abs. class herhangi bir sınıfa miras verdiğinde o sınıftan nesne üretilir.
// Haliyle de abs classdan nesneleri üretilmiş olacaktır örnek aşağıda.

// NOT: Kalıtım durumunda A B C sınıfı sırasıyla miras versin(A=>B=>C) biz C nesnesi üretmek istersek
// sırasıyla önce A sonra B sonra C nesnesi üretilecektir

// Önemli NOT : Interface türünden bir nesne hiçbir şekild mümkün değildir


MyClass2 my = new MyClass2();

abstract class MyClass
{
    public MyClass()
    {
        Console.WriteLine("Abstract Class Ctor'u ");
    }
    public void X()
    {

    }
    abstract public void Y();
    abstract public int Age { get; set; }
      
}
class MyClass2 : MyClass
{
    public MyClass2()
    {
        Console.WriteLine("Normal Class Ctor'u");
    }

    public override int Age { get; set; }
    public override void Y()
    {
       
    }
}