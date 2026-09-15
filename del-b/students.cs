//skapat class för studenter
class Students
{
    public string? StudentsName;
    public List<Courses> CoursesL  = [];

//har skapat konstruktor för studenter
     public Students (string name)
    {
        StudentsName=name;
    }
// metod för studneter pågående 
        public void Join (Courses StudentsCourse)
    {
        if (CoursesL.Contains(StudentsCourse))
        {
            
        }
    
    }
}
