// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;
using REFERENCE_TIME = System.Int64;

namespace DirectN
{
    [ComImport, Guid("62ea93ba-ec62-11d2-b770-00c04fb6bd3d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMLatency
    {
        [PreserveSig]
        HRESULT GetLatency(/* [annotation][in] _Out_ */ ref REFERENCE_TIME prtLatency);
    }
}
