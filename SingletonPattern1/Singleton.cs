namespace SingletonPattern1
{
    public sealed class Singleton
    {
        //private, parameterless constructor  
        private Singleton() { }

        private int _counter = 0;


        //static var that holds ref of the object created
        public static Singleton instance = null;

        //object to make thread safe
        public static readonly object _lock = new object();

        //method to get reference to object
        public static Singleton GetInstance
        {
            get
            {
                lock (_lock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                    return instance;
                }
            }
        }

        public void SetCounter(int x)
        {
            _counter = x;
        }

        public int GetCounter()
        {
            return _counter;
        }

        public int Counter2 { get; set; }
    }
}
