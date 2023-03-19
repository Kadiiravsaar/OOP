#region This
// 1=> Bir sınıfın uygulamanın herhangi bir yerinde üretilmiş olan instance'lerini sınıf içerisinde
// - temsil etmemizi sağlayan bir keyword

// Bir sınıf içerisinde bulunan birden fazla ctor overload'ı arasında atlamamızı sağlayan bir keyworddür.

new MyClassThis(10,"X");

new MyClassBase();

class MyClassThis
{
	public int MyProperty { get; set; }
	public MyClassThis()
	{
		this.MyProperty = 10; // this olmadan da erişilir (arkada)
		Console.WriteLine("Normal Ctor");
	}
	public MyClassThis(int a): this()
	{
		Console.WriteLine("Sadece a parametresi alan Ctor");
	}
	public MyClassThis(int a, string b): this(a)
	{
		Console.WriteLine("İki parametre alan Ctor");
	}
}

#endregion

#region Base
// Base class'ın isntance'sini temsil eden keyworddür.
// Base Classda bulunan Ctor'lar arası zıplamamızı sağlar

class MyClassBase : MyClassThis
{
	public MyClassBase(): base(2,"K")
	{
		Console.WriteLine("Son ctor");
	}
}


#endregion

#region Readonyl
// Bir class içerisinde tanımlanmış olan değişkenin veya referansın sadece okunabilir olmasını sağlar
// readonly keywordü ile işaretlenmiş olan referansın değeri iki noktada verilir;
// Ya tanımlama noktasında,
// ya da Ctor içerisinde.

// **** NOT: Const olan değişkenler sadece tanımlandıkları yerde verilmelidir.

class MyClassReadonly
{
	readonly short x = 15;
	public MyClassReadonly()
	{
		x = 61;
	}
	public void X()
	{
		// x = 68; hata vericektir.
	}
		
}

#endregion