using System;
using UnityEngine;

namespace Flavo
{
    public class BaseVariableObject<T> : ScriptableObject, IVariableObject<T>
    {
        public event Action<T> OnValueChanged;

        public event Action<T> OnValueReset;

        public T Value
        {
            get => _value;
            set
            {
                _value = value;
                OnValueChanged?.Invoke(_value);
            }
        }

        public T DefaultValue
        {
            get => _defaultValue;
        }

        [SerializeField]
        protected T _value;

        [SerializeField]
        protected T _defaultValue;

        public virtual void Reset()
        {
            _value = _defaultValue;
            OnValueReset?.Invoke(_value);
        }
    }
}
