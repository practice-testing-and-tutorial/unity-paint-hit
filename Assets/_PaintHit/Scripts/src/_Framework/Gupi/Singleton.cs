using UnityEngine;

namespace Gupi
{
    public class Singleton<T> : MonoBehaviour where T : Component
    {
        private static T _instance;

        public static T Instance
        {
            get
            {
                if (_instance == null)
                    _instance = FindObjectOfType<T>();

                if (_instance == null)
                {
                    var obj = new GameObject
                    {
                        name = typeof(T).Name
                    };

                    _instance = obj.AddComponent<T>();
                }

                return _instance;
            }
        }

        public virtual void OnDestroy()
        {
            if (_instance == this)
                _instance = null;
        }
    }

    public class SingletonPersistent<T> : MonoBehaviour where T : Component
    {
        private static T _instance;

        public static T Instance
        {
            get
            {
                if (_instance == null)
                    _instance = FindObjectOfType<T>();

                if (_instance == null)
                {
                    var obj = new GameObject
                    {
                        name = typeof(T).Name
                    };

                    _instance = obj.AddComponent<T>();
                }

                return _instance;
            }
        }

        public virtual void Awake() 
        {
            if (_instance != null)
                Destroy(gameObject);

            _instance = this as T;
            DontDestroyOnLoad(gameObject);
        }

        public virtual void OnDestroy()
        {
            if (_instance == this)
                _instance = null;
        }
    }
}
