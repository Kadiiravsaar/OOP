// Bir class'tan üretilmiş olan nesne imha edilirken otomatik çağırılan metottur.
// Destructor sadece bir kez olur ve sadece Class'da tanımlanır.
// Ctor => yapılış. yapıcı fonk, Destructor => yıkılış. yıkıcı fonk

// Bir nesne imha edilmesi için;
// - İlgili nesne herhangi bir referans ile işaretlenmiyorsa,
// - Yahut nesnenin oluşturulduğu ve kullanıldığı scope sona ermiş olmalıdır.
// - Nesne erişilmez halde olursa.

// Garbace Collector gelip imha eder.

// Uygulama da gereksiz olan nesneleri toplamak için devreye girer.
// GC c# da ne zaman iş göreceği tahmin edilemez. Yazılımcıların bu mekanizmaya müdahale etmesi önerilmez

 new MyClassDestructor();

static void X()
{
    MyClassDestructor m1 = new MyClassDestructor();

};

X();
GC.Collect(); // GC Devreye sokuldu. Bu çok tavsiye edilmez.
Console.ReadLine();

class MyClassDestructor
{
	public MyClassDestructor()
	{
		Console.WriteLine("Merhaba ilk bu tetiklendi nesne üretildi");
	}

	~MyClassDestructor()
	{
		Console.WriteLine("Nesne imha ediliyor. Son nefes");
	}

    // Deconstruct =>
	// Bir sınıf içerisinde “Deconstruct” ismiyle tanımlanan metot,
	// compiler tarafından özel olarak algılanmakta
	// ve sınıfın nesnesi üzerinden geriye hızlıca Tuple tipte bir değer döndürmemizi sağlamaktadır.


}

