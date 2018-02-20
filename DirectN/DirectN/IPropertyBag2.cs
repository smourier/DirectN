using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("22F55882-280B-11d0-A8A9-00A0C90C2004"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IPropertyBag2
    {
        [PreserveSig]
        HRESULT Read(int cProperties, [In, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] PROPBAG2[] pPropBag, /*IErrorLog*/ object pErrLog, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] object[] pvarValue, [In, Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Error, SizeParamIndex = 0)] int[] phrError);

        [PreserveSig]
        HRESULT Write(int cProperties, [In, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] PROPBAG2[] pPropBag, [In, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] object[] pvarValue);

        [PreserveSig]
        HRESULT CountProperties(out int pcProperties);

        [PreserveSig]
        HRESULT GetPropertyInfo(int iProperty, int cProperties, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] PROPBAG2[] pPropBag, out int pcProperties);

        [PreserveSig]
        HRESULT LoadObject([MarshalAs(UnmanagedType.LPWStr)] string pstrName, uint dwHint, [MarshalAs(UnmanagedType.IUnknown)] object pUnkObject, /*IErrorLog*/ object pErrLog);
    }
}
