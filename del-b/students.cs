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

}