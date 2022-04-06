//typ name = literal
string message;// = "Hello World";
message = "Hello World";

//string message = "Hugo";  //geht nicht
//int message = 42;

int number = 9;  //OK, aber da nicht verwendet sinnfrei

//int number2 = 4.2;//Compiler-Fehler, ein double-Literal kann nicht einer int-Variable zugeordnet werden

message = "Goodbye World";

//message = 42; //Compiler-Fehler
//message = 'H';//Compiler-Fehler
message = 'Hello Jupiter';//Compiler-Fehler, Character ist immer ein Einzelzeichen
Console.WriteLine(message);
