using System;
using UnityEngine;

namespace Flavo
{
    public abstract class BaseController : MonoBehaviour, IController
    {
        public event Action<IController> OnInitializationCompleted;

        public virtual void InitializeController()
        {
            OnInitializationCompleted?.Invoke(this);
        }
    }
}
