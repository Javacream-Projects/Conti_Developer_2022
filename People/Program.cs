using Javacream.Music;

Console.WriteLine("starting");
//Instrument i1 = new Instrument();
//i1.MakeSound();

Guitar guitar1 = new Guitar("Fender 6 String");
Guitar guitar2 = new Guitar("Rickenbacher");
Bass bass = new Bass("Höfner");
Drum drum = new Drum("Ludwig");
Instrument[] instruments = {guitar1, guitar2, bass, drum};
Band band = new Band(instruments);
band.Play();