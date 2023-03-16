// Shallow copy

using NesneKopyalama;

ShallowCopy m1 = new ShallowCopy();
ShallowCopy m2 = m1;
ShallowCopy m3 = m2;
ShallowCopy m4 = new ShallowCopy();

ShallowCopy x1 = new ShallowCopy();
ShallowCopy x2 = x1; // shallow copy
ShallowCopy x3 = x1.Clone(); // deep copy

// Bir nesne birden fazla referans ile işaretleniyorsa burda shallow copy vardır
// Deep copyde elde ki veri türetilmeli, çoğaltılması


// deep copy

int a = 5;
int b = a;

Console.WriteLine(a*5); // 25
Console.WriteLine(b); // 5