using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WB.RX
{
    public struct NoMean
    {
        static readonly NoMean @default = new NoMean();

        public static NoMean Default { get { return @default; } }
    }
}
