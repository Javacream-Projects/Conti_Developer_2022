using Javacream.Util;
namespace Javacream.People{
    public enum Gender{
        Male, Female, Diverse
    }
    public class Person : Object{ //"Person extends Object", implizit immer der Fall

        public static int PeopleCounter {get; private set;} = 0;
        private string? _Lastname;
        public string Lastname{
            get {
                return _Lastname!.ToUpper();
            }
            set {
                if (value.Length > 0 && value.Length < 32){
                    _Lastname = value;
                }else{
                    Exception e = new Exception("Validation Error: ...");
                    throw e;
                }
            }
        }

        public string Name{
            get {
                return Firstname + " " + Lastname;
            }
        }

        public string Firstname{get;}
        public int Height{get;}
        public Gender Gender{get;set;}

        public string SayHello(){
            //Innerhalb einer Methode existiert die implizite Variable "this"
            //sawitzki.SayHello -> this = sawitzki
            return "Hello, my name is " + this.Lastname;
            //return "Hello, my name is " + Lastname;//Der Compiler ergänzt hier this.
        }
        public Person(string Lastname, string Firstname, int Height, Gender Gender){
            this.Lastname = Lastname;
            this.Firstname = Firstname;
            this.Height = Height;
            this.Gender = Gender;
            Person.PeopleCounter++;
        }
        private Person? partner;

        public void Marry(Person? partner){
            if (partner == null){
                throw new Exception("marry failed: partner was null");
            }
            if (partner == this){
                throw new Exception("marry failed: you cannot marry yourself");
            }
            if (partner.partner != null){
                throw new Exception("marry failed: partner is married");
            }
            if (this.partner != null){
                throw new Exception("marry failed: you are married");
            }
            this.partner = partner;
            partner.partner = this;
        }

        public void Divorce(){
            if (this.partner == null){
                throw new Exception("Divorce failed: you are not married!");
            }
            this.partner.partner = null;
            this.partner = null;
        }

        public Address address {get;set;}
    }
    public class Student : Person{
         public Student(string Lastname, string Firstname, int Height, Gender Gender) : base(Lastname, Firstname, Height, Gender) {
         }
   }
    
}