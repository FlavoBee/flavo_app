using UnityEngine;

namespace Flavo
{
    public interface IScreenView : IView
    {
        void Open();

        void Close();
    }
}
