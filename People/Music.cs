namespace Javacream.Music
{
    
    public interface ISoundGenerator{
        string MakeSound();

    }
    public abstract class Instrument:ISoundGenerator
    {
        public abstract string MakeSound();
        public string Description { get; set; }
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
                this.SoundGenerators = new List<ISoundGenerator>();
            }

    private List<ISoundGenerator> SoundGenerators;
    public void Play()
    {
        foreach (ISoundGenerator i in SoundGenerators)
        {
            Console.WriteLine(i.MakeSound());
        }
    }
    public void AddSoundGenerator(ISoundGenerator i){
        this.SoundGenerators.Add(i);
    }
    public void RemoveSoundGenerator(ISoundGenerator i){
        this.SoundGenerators.Remove(i);
    }
}
}
