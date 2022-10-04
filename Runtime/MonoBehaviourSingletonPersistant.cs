
using UnityEngine;

namespace OSM.Utils
{
    public class MonoBehaviourSingletonPersistent<T> : MonoBehaviour where T : Component
    {
        public static T Instance { get; private set; }
	
        private void Awake()
        {
            if (Instance == null) 
            {
                Instance = this as T;
                DontDestroyOnLoad (this);
                OnAwake();
            } 
            else 
            {
                Destroy (this);
            }
        }

        protected virtual void OnAwake()
        {
            
        }
    }
}