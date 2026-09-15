//skapat objekter i form av studenter för att testa 
Students Rameel = new ("Rameel Siddiqui");
Students Jameel = new ("Jameel Deal");
Students Bill = new ("Bill Jill");
Students Talha = new ("Talha Talwar");
// kurs objekt för att testa 
Courses Mathematic = new ("Mathematics");

// anropar enroll metoden
Mathematic.Enroll(Rameel);
Mathematic.Enroll(Jameel);
Mathematic.Enroll(Bill);
Mathematic.Enroll(Talha);

// anropar rollcall metoden som skriver ut lista på studenter i kursen.
Mathematic.RollCall();