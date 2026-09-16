//skapat objekter i form av studenter 
Students Rameel = new ("Rameel Siddiqui");
Students Jameel = new ("Jameel Deal");
Students Bill = new ("Bill Jill");
Students Talha = new ("Talha Talwar");
Students James = new ("James Bond");
// kurs objekt
Courses Mathematic = new ("Mathematics");
Courses Physics = new ("Physics");



// anropar enroll metoden
Mathematic.Enroll(Rameel);
Mathematic.Enroll(Jameel);
Mathematic.Enroll(Bill);
// anropar rollcall metoden för mathematics som skriver ut lista på studenter i kursen.
Mathematic.RollCall();
Console.WriteLine("");


// tar bort bill från mathematics kursen
Mathematic.Remove(Bill);

Talha.Join(Mathematic);
Mathematic.Enroll(James);// james får inte plats i kursen pga den är full efter talha joined
// anropar rollcall metoden för mathematics som skriver ut lista på studenter i kursen.
Mathematic.RollCall();

Console.WriteLine("");


Talha.Join(Physics); // lägger till i samma kurs
Physics.Enroll(Talha);// inga dubletter visas

Talha.Schedule();

Console.WriteLine("");
// testar att ta bort student som inte finns i kurs
Physics.Remove(Rameel);// programmet kraschar inte
Rameel.Leave(Physics);// programmet kraschar fortfarande inte

// Physics.RollCall();

Console.WriteLine("To-string test:");
Console.WriteLine(Talha.ToString());

Console.WriteLine("To-string antal platser test:");
Console.WriteLine(Mathematic.ToString());
Console.WriteLine(Physics.ToString());