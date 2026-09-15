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
    
}
