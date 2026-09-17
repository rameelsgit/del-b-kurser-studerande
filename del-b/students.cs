//skapat class för studenter. håller koll på vilka kurser studenten läser
using System.Security.Cryptography.X509Certificates;

class Students
{
    public string? StudentsName;
    public List<Courses> CoursesL  = [];

//har skapat konstruktor för studenter
     public Students (string name)
    {
        StudentsName=name;
    }
// metod för studenter, som lägger till dem i courses
        public void Join (Courses studentsCourse)
    {
        // studentcourse anropar Courses egna Enroll metod. Och följer alla enroll kraven. 
        studentsCourse.Enroll(this);
    }
        
        //leave metod som kopplar med studentlistan. metoden tar bort kurs från studenten och uppdaterar åt båda hållen
        public void Leave (Courses leaveCourse)
    {
        CoursesL.Remove(leaveCourse);
        leaveCourse.StudentL.Remove(this);
    }
    //metod för schedule som skriver ut elevens kurser
    public void Schedule()
    {
        Console.WriteLine($"Schedule for {StudentsName}");
        foreach ( var StudentsName in CoursesL)
        //anropar coursename från Course classen annars kunde jag inte visa individuella kurser
        {
            Console.WriteLine($" {StudentsName.CourseName} ");
        }
    }

// to-string metod som skriver ut den studerandes namn
    public override string ToString()
    {
        return $"{StudentsName}";
    }

}
