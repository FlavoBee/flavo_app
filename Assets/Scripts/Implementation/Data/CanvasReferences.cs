using UnityEngine;

namespace Flavo
{
    [System.Serializable]
    public class CanvasReferences : ICanvasReferences
    {
        public Canvas Canvas => _canvas;

        public GameObject HomeScreen => _homeScreen;

        [SerializeField]
        private Canvas _canvas;

        [SerializeField]
        private GameObject _homeScreen;
    }
}
