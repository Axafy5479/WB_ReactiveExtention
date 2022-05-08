using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

namespace WB.RX
{
    public class SelectObservable<TSource,TResult> : IObservable<TResult>
    {
        public SelectObservable(IObservable<TSource> observable, Func<TSource,TResult> projection)
        {
            source = observable;
            this.projection = projection;
            Value = projection(observable.Value);
        }
        
        private readonly IObservable<TSource> source;
        private readonly Func<TSource,TResult> projection;
        public TResult Value { get; }


        public IDisposable Subscribe(Action<TResult> observer)
        {
            return source.Subscribe(val =>
            {
                    observer(projection(val));
            });
        }

    }
}