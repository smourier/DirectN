// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("a8809222-07bb-48ea-951c-33158100625b"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IGetCapabilitiesKey
    {
        [PreserveSig]
        HRESULT GetCapabilitiesKey(/* [annotation][out] _Out_ */ out IntPtr pHKey);
    }
}
