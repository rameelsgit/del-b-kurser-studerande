//skapat objekter i form av studenter för att testa 
Students Rameel = new ("Rameel Siddiqui");
Students Jameel = new ("Jameel Deal");
Students Bill = new ("Bill Jill");
Students Talha = new ("Talha Talwar");
// kurs objekt för att testa 
Courses Mathematic = new ("Mathematics");
Courses Physics = new ("Physics");


// anropar enroll metoden
Mathematic.Enroll(Rameel);
Mathematic.Enroll(Jameel);
Mathematic.Enroll(Bill);


// anropar rollcall metoden som skriver ut lista på studenter i kursen.
Mathematic.RollCall();

Talha.Join(Physics);
Talha.Join(Physics);

// Physics.Enroll(Talha);

Talha.Join(Mathematic);
Talha.Schedule();

Physics.RollCall();

Console.WriteLine("to string test:");
Console.WriteLine(Talha.ToString());

Console.WriteLine("to string antal platser test:");
Console.WriteLine(Mathematic.ToString());