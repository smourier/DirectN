// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1effectauthor.h(252,9)
using System;
using System.Runtime.InteropServices;
using PD2D1_PROPERTY_GET_FUNCTION = System.IntPtr;
using PD2D1_PROPERTY_SET_FUNCTION = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_PROPERTY_BINDING
    {
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string propertyName;
        public IntPtr setFunction;
        public IntPtr getFunction;
    }
}
