using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    public delegate HRESULT PD2D1_PROPERTY_GET_FUNCTION([MarshalAs(UnmanagedType.IUnknown)] object effect, IntPtr data, int dataSize, out int actualSize);
}
