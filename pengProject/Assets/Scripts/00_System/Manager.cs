using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KMS.Singleton
{
    public abstract class Manager<T> : MonoBehaviour where T : Manager<T>
    {
        private T instance;
        public T Instance
        {
            get 
            {
                if(instance == null) 
                {
                    instance = FindObjectOfType<T>();
                }
                return instance; 
            }
        }

        public virtual void Init() { }
    }
}

