using Javacream.People;
using Javacream.Util;
using System; //System-Namespace wird automatisch immer benutzt

Person p = new Person("Sawitzki", "Rainer", 183, Gender.Male);
Student s = new Student("Einstein", "Albert", 176, Gender.Male, "LMU");
Worker w = new Worker("Schufter", "Hannah", 176, Gender.Female, "Integrata");
s.Study();
w.Work();

s.Marry(w); //Geht!, aber die Signatur ist doch  Marry(Person partner)!
//Aber: Ein Student/Worker ist eine Person!
Person ps = s;
Person pw = w;
//Student sw = w;//Das geht nicht, ein Worker ist keine Person!

//Natürlich ist ein Student/Worker/Person auch ein Object!
Object os = s;
Object ow = w;
Object op = p;

/*

WICHTIG: Achten Sie auf den Code-Assist und den Debugger!

- Welche Methoden und Attribute werden z.B. für s, ps, os angezeigt
- Was ist im Debugger zu sehen für z.B. s, ps, os 

*/