using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WB.RX
{

    public static class Observable
    {

        public static IObservable<T> Where<T>(this IObservable<T> observable, Predicate<T> predicate)
        {
            return new WhereObservable<T>(observable, predicate);
        }
        
        public static IObservable<TResult> Select<TSource,TResult>(this IObservable<TSource> observable, Func<TSource,TResult> projection)
        {
            return new SelectObservable<TSource,TResult>(observable, projection);
        }
    }
}
