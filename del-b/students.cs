//skapat class för studenter
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
// metod för studenter, som lägger till dem i curser
        public void Join (Courses studentsCourse)
    {
        // studentcourse anropar Enroll metoden här och följer alla enroll kraven.
        studentsCourse.Enroll(this);
        // if (!CoursesL.Contains(studentsCourse))
        // {
        // CoursesL.Add(studentsCourse);
        // studentsCourse.StudentL.Add(this);
        // }
        // else
        // {
        //     Console.WriteLine("You are alrady enrolled in this course");
        // }
    }
        
        //leave metoed som kopplar med studentlistan
        public void Leave (Courses leaveCourse)
    {
        CoursesL.Remove(leaveCourse);
        leaveCourse.StudentL.Remove(this);
    }
    
}
