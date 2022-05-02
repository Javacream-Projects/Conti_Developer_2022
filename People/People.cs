namespace People{
    public class Person{
        public string Lastname{get;set;}
        public string Firstname{get;}
        public int Height{get;}
        public char Gender{get;set;}

        public string SayHello(){
            //Innerhalb einer Methode existiert die implizite Variable "this"
            //sawitzki.SayHello -> this = sawitzki
            return "Hello, my name is " + this.Lastname;
            //return "Hello, my name is " + Lastname;//Der Compiler ergänzt hier this.
        }
        public Person(string Lastname, string Firstname, int Height, char Gender){
            Console.WriteLine("a person is created");
            this.Lastname = Lastname;
            this.Firstname = Firstname;
            this.Height = Height;
            this.Gender = Gender;
        }
        private Person partner;

        public string marry(Person partner){
            this.partner = partner;
            partner.partner = this;
            return "OK";
        }
    }
}