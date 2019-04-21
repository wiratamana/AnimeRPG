using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tamana
{
    public class SingletonMonobehaviour<T> : MonoBehaviour
    {
        public static T instance { protected set; get; }

        protected virtual void Awake()
        {
            instance = gameObject.GetComponent<T>();
        }
    }

}
