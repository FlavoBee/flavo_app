using System;
using UnityEngine;

namespace Flavo
{
    public interface IVariableObject<T>
    {
        event Action<T> OnValueChanged;

        event Action<T> OnValueReset;

        T Value { get; set; }

        T DefaultValue { get; }

        void Reset();
    }
}
