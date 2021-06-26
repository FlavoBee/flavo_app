using System;

namespace Flavo
{
    public interface IController
    {
        event Action<IController> OnInitializationCompleted;

        void InitializeController();
    }
}
