using System;

namespace Singletons
{
    public abstract class Singleton<T> where T : class
    {
        private static volatile T _instance;
        private static readonly object _locker = new();

        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_locker)
                    {
                        _instance ??= Activator.CreateInstance(typeof(T), true) as T;
                    }
                }
                return _instance;
            } 
        }
    }
}