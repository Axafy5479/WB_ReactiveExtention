using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WB.RX
{
    public interface IObserver<T>
    {
       
        public void OnNext(T val);
    }
}
