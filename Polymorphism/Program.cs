// Polimorphism nedir ? 
// 2 veya daha fazla farklı nesnenin Aynı tür Class'lardan referanslardan, referans almasıdır, işaretlenebilmesidir.
// Örnek Kaplan ve aslan ikisi de kedigillerdendir. Hepsi bir kedidir ve aslandır. 
//              A a                           =                 new A();
// A türünden bir referasn a noktası ile işaretlendi.      A türünden bir Nesne

// *** Bir nesnenin birden fazla ref ile işaretlenmesi; o nesnenin birden fazla türün davranışlarını gösterebilmesini sağlar

MyClass myClass = new MyClass2();

Erkek erkek = new Erkek();
Insan ınsan = new Erkek();

#region örnek 1
class MyClass
{

}
class MyClass2 : MyClass
{

}

#endregion

#region Örnek 2
class Insan
{

}
class Erkek : Insan
{

}
class Kadin : Insan
{

}



#endregion



