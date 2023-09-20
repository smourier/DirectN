// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("f938c991-3029-11cf-8c44-00aa006b6814"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMPhysicalPinInfo
    {
        [PreserveSig]
        HRESULT GetPhysicalType(/* [annotation][out] _Out_ */ out long pType, /* [annotation][out] _Out_ */ out IntPtr ppszType);
    }
}
