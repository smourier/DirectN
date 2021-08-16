using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("00000101-0000-0000-C000-000000000046"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IEnumString
    {
        [PreserveSig]
        HRESULT Next(int celt, [In, Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPWStr)] string[] rgelt, out int celtFetched);

        [PreserveSig]
        HRESULT Skip(int celt);

        [PreserveSig]
        HRESULT Reset();

        [PreserveSig]
        HRESULT Clone(out IEnumString ppenum);
    }
}
