using System.Text;
using lab;
using var fs = new FileStream("data.txt",FileMode.OpenOrCreate);
using var sw = new StreamWriter(fs);

Group a = new Group();

string source = a.get_Source();
Console.WriteLine(source);
var group = new Group()
{
    Capacity = 5,
    Teacher = new() { Age = 20, Name = "Elvin", Surname = "Azimov", Salary = Int32.MaxValue },
    Students = new()
    {
        new("Omar", "Xayyam", 20),
        new("Medina", "Abbasova", 19),
        new("Shems", "Ismayilova", 18),
        new("Shems", "Ismayilova", 18),
        new("Shems", "Ismayilova", 18),
        new("Anar", "Məmmədov", 24),
        new("Fidan", "Axundbeyli", 19),
        
    }
};


try
{
    group.AddStudent(new("Maksimus", "Prime", 15));
}
catch (StudentException ex)
{
    Console.WriteLine(ex.Source);
    
    sw.WriteLine(source);
    sw.WriteLine(ex.Source);
    
    Console.WriteLine( "Количество студентов " + group.Students.Count); 
}
