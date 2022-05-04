namespace Javacream.Music{
    public abstract class Instrument {
        public string Description {get; set;}
        public abstract string MakeSound();
    }

    public class Guitar:Instrument{
        public override string MakeSound(){
            return "Klimper, Klamper";
        }
    }
}