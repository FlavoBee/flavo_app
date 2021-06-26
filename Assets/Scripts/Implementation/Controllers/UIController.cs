using UnityEngine;

namespace Flavo
{
    public class UIController : BaseController
    {
        public ICanvasReferences CanvasReferences => _canvasReferences;

        [SerializeField]
        private CanvasReferences _canvasReferences;
    }
}
