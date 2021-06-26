using System;

namespace Flavo
{
    public interface IAppController : IController
    {
        event Action OnApplicationSuspend;

        event Action OnApplicationRestart;

        /// <summary>
        /// Initialization point for the application
        /// </summary>
        void InitializeApplication();

        /// <summary>
        /// Quit/Suspend point for the application
        /// </summary>
        void QuitApplication();
    }
}
