using System;
using UnityEngine;

namespace Flavo
{
    public class AppController : BaseController, IAppController
    {
        #region PROPERTIES

        public event Action OnApplicationSuspend;

        public event Action OnApplicationRestart;

        #endregion


        #region SERIALIZED FIELDS

        [SerializeField]
        private BaseController[] _controllers;

        #endregion


        #region PRIVATE FIELDS

        private bool _applicationQuitScheduled;
        private int _initializedControllers;

        #endregion


        #region ENGINE OVERRIDE

        private void Start()
        {
            InitializeController();
        }

        private void OnApplicationPause(bool pauseStatus)
        {
            if (!pauseStatus)
            {
                OnApplicationRestart?.Invoke();
            }
            else
            {
                OnApplicationSuspend?.Invoke();
            }
        }

        #endregion


        #region IAPPCONTROLLER IMPLEMENTATION

        public override void InitializeController()
        {
            _applicationQuitScheduled = false;
            _initializedControllers = 0;

            InitializeApplication();
            base.InitializeController();
        }

        public void InitializeApplication()
        {
            for (int i = 0; i < _controllers.Length; i++)
            {
                _controllers[i].OnInitializationCompleted += HandleOnControllerInitializedCallback;
                _controllers[i].InitializeController();
            }
        }

        public void QuitApplication()
        {
            _applicationQuitScheduled = true;
        }

        #endregion

        private void HandleOnControllerInitializedCallback(IController controller)
        {
            controller.OnInitializationCompleted -= HandleOnControllerInitializedCallback;

            _initializedControllers++;
            if (_initializedControllers == _controllers.Length)
            {
                StartApplication();
            }
        }

        private void StartApplication()
        {

        }
    }
}
