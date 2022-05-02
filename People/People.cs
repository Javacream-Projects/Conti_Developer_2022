namespace People{
    public class Person{
        public string lastname{get;set;}
        public string firstname{get;}
        public int height{get;}
        public char gender{get;set;}

        public string sayHello(){
            return "Hello";
        }
        public Person(string ln, string fn, int h, char g){
            Console.WriteLine("a person is created");
            lastname = ln;
            firstname = fn;
            height = h;
            gender = g;
        }
    }
}