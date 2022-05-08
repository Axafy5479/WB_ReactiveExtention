using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WB.RX
{
    public interface IObservable<out T>
    {
        System.IDisposable Subscribe(System.Action<T> observer);
        public T Value { get; }
    }
}
