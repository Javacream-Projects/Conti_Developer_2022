namespace Javacream.Music
{
    public abstract class Instrument
    {
        public string Description { get; set; }
        public abstract string MakeSound();
        public Instrument(string desc){
            this.Description = desc;
        }
    }

    public class Guitar : Instrument
    {
        public Guitar(string desc): base(desc){}
        public override string MakeSound()
        {
            return "Klimper, Klamper";
        }
    }

    public class Drum : Instrument
    {
        public Drum(string desc): base(desc){}
        public override string MakeSound()
        {
            return "Wumm";
        }
    }
    public class Bass : Instrument
    {
                public Bass(string desc): base(desc){}

        public override string MakeSound()
        {
            return "Schrumm";
        }
    }
public class Band
{
            public Band()
            {
                this.Instruments = new List<Instrument>();
            }

    private List<Instrument> Instruments;
    public void Play()
    {
        foreach (Instrument i in Instruments)
        {
            Console.WriteLine(i.MakeSound());
        }
    }
    public void AddInstrument(Instrument i){
        this.Instruments.Add(i);
    }
    public void RemoveInstrument(Instrument i){
        this.Instruments.Remove(i);
    }
}
}
