 // skapat class för courses
 class Courses 
{
    public string? CourseName;
    public int MaxSeats= 5;
    public List<Students> StudentL = [];
// skapat konstruktor för courses
    public Courses (string name)
    {
        CourseName=name;
    }
// metod för att studenter ska kunna enroll i kurser,  
    public void Enroll (Students CourseStudents)
    {
        // kollar om kursen är full annars läggs studenterna till i kursen 
        if (StudentL.Count()==MaxSeats)
        {
            Console.WriteLine("The course is full");
            return;
        }
        StudentL.Add(CourseStudents);
    }

// denna metoden tar bort studenter från cursen, .remove tar bort från studnet listan
    public void Remove (Students RemoveStudents)
    {
        StudentL.Remove(RemoveStudents);
    }
// rollcall metod använder for-loop för att skriva ut en lista av studenter genom att räkna student namnen i listan
    public void RollCall( )
    {
        Console.WriteLine("Roll call: ");
        for (int i = 0; i< StudentL.Count; i++ )
        {
            Console.WriteLine(StudentL[i].StudentsName);
        }
    }

    
}
