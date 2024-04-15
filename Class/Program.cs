using Class;


//Bir öğrenci için bilgi tutalım 


var isim = "Merve";
var age = 24;

//Birden fazla öğrenci adı tutmak için list kullandık
//C# List = JS Array
var isimler = new List<string> { "Derin", "Merve", "Ahmet" };

//Öğrencinin birden fazla bilgisi için 
//C# Class = JS Object

var merve = new Student();
merve.Name = "Merve";
merve.Age = 24;
merve.Email = "yollcumerve@gmail.com";

var ahmet = new Student();
merve.Name = "Ahmet";
merve.Age = 25;
merve.Email = "ahmetdok@gmail.com";


var students2 = new List<Student>
    { merve, ahmet }; //Burada List<> içerisine ne type verirsen eşittir sağ tarafında da aynı tip data saklayabilirsin 
var studentsName = new List<string>();
foreach (var student in students2) studentsName.Add(student.Name);