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
        private Person? partner;

        public string Marry(Person? partner){
            if (partner == null){
                return "marry failed: partner was null";
            }
            if (partner == this){
                return "marry failed: you cannot marry yourself";
            }
            if (partner.partner != null){
                return "marry failed: partner is married";
            }
            if (this.partner != null){
                return "marry failed: you are married";
            }
            this.partner = partner;
            partner.partner = this;
            return "marry OK";
        }

        public string Divorce(){
            if (this.partner == null){
                return "Divorce failed: you are not married!";
            }
            this.partner.partner = null;
            this.partner = null;
            return "divorce OK";
        }
    }
}