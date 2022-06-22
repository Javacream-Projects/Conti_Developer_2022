using Javacream.IsbnGenerator.API;
using Javacream.Util;
namespace Javacream.IsbnGenerator.Impl
{

    public abstract class BaseIsbnService:IIsbnService{
        public abstract Isbn Next();
        protected string _prefix = Configuration.GetConfiguration("isbn.prefix");
        protected string _countryCode = Configuration.GetConfiguration("isbn.countryCode");
    }
    public class CounterIsbnService:BaseIsbnService{
        private static int _counter = 1;

        public override Isbn Next(){
            return new Isbn(_prefix, _countryCode, 1,2,4, _counter++);

        }
    }

    public class RandomIsbnService:BaseIsbnService{
        private Random random = new Random();

        public override Isbn Next(){
            return new Isbn(_prefix, _countryCode, 1,2,3, random.Next(0, 999));

        }
    }
}
