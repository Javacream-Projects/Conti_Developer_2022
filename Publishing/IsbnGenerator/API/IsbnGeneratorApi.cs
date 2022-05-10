namespace Javacream.IsbnGenerator.API{
    public class Isbn
    {
        private string _prefix;
        private string _countryCode;
        private int _part1;
        private int _part2;
        private int _part3;
        private int _part4;

        public Isbn(int p1, int p2, int p3, int p4) :this("ISBN:", "-world", p1, p2, p3, p4)
        {}

        public Isbn(string prefix, string countryCode, int p1, int p2, int p3, int p4){
            this._part1 = p1;
            this._part2 = p2;
            this._part3 = p3;
            this._part4 = p4;
            this._countryCode = countryCode;
            this._prefix = prefix;
        }

        public override int GetHashCode()
        {
            //Prinzipiell OK, aber führt zu Performance-Problemen
            //return 0;
            //Gut unter Annahme, dass jeder Part nur den Wertebereich 1-999 haben kann
            return 1000000000 * _part1 + 1000000 * _part2 + 1000 * _part3 + _part4;
        }

        public override bool Equals(Object? obj)
        {
            if (obj == null)
            {
                return false;
            }
            else
            {
                if (this == obj)
                {
                    return true;
                }
                if (obj.GetType() != this.GetType())
                {
                    return false;
                }

                Isbn toCompare = (Isbn)obj;

                return this._part1 == toCompare._part1 && this._part2 == toCompare._part2 && this._part3 == toCompare._part3 && this._part4 == toCompare._part4;
            }
        }


        public override string ToString()
        {
            string isbnAsString = _prefix + _part1 + "-" + _part2 + "-" + _part3 + "-" + _part4 + _countryCode;
            return isbnAsString;
        }

    }

    public interface IIsbnService{
        public Isbn Next();
    }
}