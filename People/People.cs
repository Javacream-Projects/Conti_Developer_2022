namespace People{
    public class Person{
        public string Lastname{get;set;}
        public string Firstname{get;}
        public int Height{get;}
        public char Gender{get;set;}

        public string SayHello(){
            return "Hello";
        }
        public Person(string ln, string fn, int h, char g){
            Console.WriteLine("a person is created");
            Lastname = ln;
            Firstname = fn;
            Height = h;
            Gender = g;
        }
    }
}