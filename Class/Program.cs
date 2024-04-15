using Class;


//Bir öğrenci için bilgi tutalım 


string isim = "Merve";
int age = 24;

//Birden fazla öğrenci adı tutmak için list kullandık
//C# List = JS Array
List<string> isimler = new List<string>(){"Derin","Merve","Ahmet"}; 

//Öğrencinin birden fazla bilgisi için 
//C# Class = JS Object

Student merve = new Student();
merve.Name = "Merve";
merve.Age = 24;
merve.Email = "yollcumerve@gmail.com";

Student ahmet = new Student();
merve.Name = "Ahmet";
merve.Age = 25;
merve.Email = "ahmetdok@gmail.com";


List<Student> students2 = new List<Student>(){merve,ahmet }; //Burada List<> içerisine ne type verirsen eşittir sağ tarafında da aynı tip data saklayabilirsin 
List<string> studentsName = new List<string>() { };
foreach (var student in students2)
{
    studentsName.Add(student.Name);
}