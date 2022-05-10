using Javacream.IsbnGenerator.API;
namespace Javacream.IsbnGenerator.Impl
{
    public class CounterIsbnService:IIsbnService{
        private static int _counter = 1;

        public Isbn Next(){
            return new Isbn(1,2,3, _counter++);

        }
    }

    public class RandomIsbnService:IIsbnService{
        private Random random = new Random();

        public Isbn Next(){
            return new Isbn(1,2,3, random.Next(0, 999));

        }
    }
}
