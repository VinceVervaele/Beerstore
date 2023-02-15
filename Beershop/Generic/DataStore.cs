namespace Beershop.Generic
{
    public class DataStore
    {

        // https://www.tutorialsteacher.com/csharp/csharp-generics


        private string[] _data;

        public DataStore()
        {
            _data = new string[10];
        }
        public void AddOrUpdate(int index, string item)
        {
            if (index >= 0 && index < 10)
                _data[index] = item;
        }

        public string? GetData(int index)
        {
            if (index >= 0 && index < 10)
                return _data[index];
            else
                return default(string);
        }
    }
    public class DataStore<T>
    {

        // https://www.tutorialsteacher.com/csharp/csharp-generics

        private T[] _data;

        public DataStore()
        {
            _data = new T[10];
        }

        public void AddOrUpdate(int index, T item)
        {
            if (index >= 0 && index < 10)
                _data[index] = item;
        }

        public T? GetData(int index)
        {
            if (index >= 0 && index < 10)
                return _data[index];
            else
                return default(T);
        }
    }
}
