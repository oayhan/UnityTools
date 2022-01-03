using System.Linq;
using UnityEngine;

namespace Singletons
{
    public abstract class SingletonScriptableObject<T> : ScriptableObject where T : ScriptableObject
    {
        static T _instance = null;

        public static T Instance
        {
            get
            {
                if (!_instance)
                {
                    Resources.LoadAll<T>("");
                    _instance = Resources.FindObjectsOfTypeAll<T>().FirstOrDefault();
                }
                return _instance;
            }
        }
    }
}