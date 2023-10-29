using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct ADPCMCOEFSET
    {
        public adpcmcoef_tag coef;
    }
}
