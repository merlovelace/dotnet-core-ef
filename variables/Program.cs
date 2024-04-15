/*
 * int: ondalıklı olmayan
 * double: ondalıklı sayı -> bellekte kapladığı alan daha fazla
 * short
 * byte: 0-255 arası
 * bool:

*/

/* DİZİLER */

var krediler = new string[4]; //-> 5li dize ama burada krediler[5] = "lorem" gibi ekleme yapılamaz


/*DÖNGÜLER*/

for (var i = 0; i < krediler.Length; i++) Console.WriteLine(krediler[i]);

//veya sadece diziler için kullanılan bir döngü vardır 

foreach (var i in krediler) Console.WriteLine(i);

var sayac = 0;
while (sayac < krediler.Length)
{
    Console.WriteLine(krediler[sayac]);
    sayac++;
}


/*LİSTELER*/

string[] sehirler = { "İstanbul", "İzmir" };
sehirler[2] = "Bursa"; //bu bize bir dizi olduğundan "range out of array sorunu verecektir"

var sehirler2 = new List<string>();
sehirler2.Add("Ankara");
sehirler2.Add("Adıyaman");

sehirler2.Remove("Ankara");
sehirler2.Contains("İstanbul"); //Bu bize bool değer dönecektir