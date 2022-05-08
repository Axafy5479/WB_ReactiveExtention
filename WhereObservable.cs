using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

namespace WB.RX
{
    public class WhereObservable<T> : IObservable<T>
    {
        public WhereObservable(IObservable<T> observable, Predicate<T> predicate)
        {
            source = observable;
            this.predicate = predicate;
            Value = observable.Value;
        }
        
        private readonly IObservable<T> source;
        private readonly Predicate<T> predicate;
        public T Value { get; }


        public IDisposable Subscribe(Action<T> observer)
        {
            return source.Subscribe(val =>
            {
                if (predicate(val))
                {
                    observer(val);
                }
            });
        }

    }
}
