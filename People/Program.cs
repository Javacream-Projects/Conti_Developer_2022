using Javacream.Music;

Console.WriteLine("starting");
//Instrument i1 = new Instrument();
//i1.MakeSound();

Guitar guitar1 = new Guitar("Fender 6 String");
Guitar guitar2 = new Guitar("Rickenbacher");
Bass bass = new Bass("Höfner");
Drum drum = new Drum("Ludwig");
Band band = new Band();
band.AddInstrument(guitar1);
band.AddInstrument(guitar2);
band.AddInstrument(bass);
band.AddInstrument(drum);
band.Play();
band.RemoveInstrument(drum);
band.Play();
