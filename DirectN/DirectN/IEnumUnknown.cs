using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("00000100-0000-0000-C000-000000000046"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IEnumUnknown
    {
        [PreserveSig]
        HRESULT Next(int celt, [Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.IUnknown)] object[] rgelt, ref int celtFetched);

        [PreserveSig]
        HRESULT Skip(int celt);

        [PreserveSig]
        HRESULT Reset();

        [PreserveSig]
        HRESULT Clone(out IEnumUnknown enumUnknown);
    }
}
