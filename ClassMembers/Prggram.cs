// Field

//MyClasField myClass = new MyClasField();
//Console.WriteLine(myClass.b);
//Console.ReadKey();


// Property

//MyClassProperty myClassProperty = new MyClassProperty();
//Console.WriteLine(myClassProperty.Yasi); // Yaşının değeri çağırılır
//myClassProperty.Yasi = 35; // Set bloğu çağrılır

// This
//MyClassThis1 m1 = new MyClassThis1();


#region Önemli not

// örneğin new MyClass() yapıp bir referans ile işaretlemediğimizde heap'de gereksiz yere kalır
// memory'de boşa alan tahsis eder. Referanssız bir nesnenin memoryde alan tahsis etmesi durumunda 
// Garbage Collector dediğimiz çöp toplayıcı sayesinde temizlenir

// GC : Heap'de referanssız olan nesneleri imha etmekten/temizlemekten sorumlu yapılanmaktadır.

#endregion

// object initializer

using ClassMembers;

ObjectInitializerGenelNot obj = new ObjectInitializerGenelNot()
{
    MyProperty = 110 // nesne ilk oluşurken değeri burda atayabiliriz.
};

