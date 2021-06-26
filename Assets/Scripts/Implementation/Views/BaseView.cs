using UnityEngine;

namespace Flavo
{
    public abstract class BaseView : MonoBehaviour, IView
    {
        public virtual void Initialize()
        {
            throw new System.NotImplementedException();
        }

        public virtual void CleanUp()
        {
            throw new System.NotImplementedException();
        }
    }
}
