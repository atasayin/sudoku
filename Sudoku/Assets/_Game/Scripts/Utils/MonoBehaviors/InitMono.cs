using UnityEngine;

namespace Utils.MonoBehaviors
{
    public abstract class BaseInitMono : MonoBehaviour
    {
        
    }
    public abstract class InitMono : BaseInitMono
    {
        public abstract void Initialize();
    }
    
    public abstract class InitMono<T> : BaseInitMono
    {
        public abstract void Initialize(T arg);
    }
}