// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("4a724bca-ff6a-4c07-8e0d-7a358421cf06"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSignedLibrary
    {
        [PreserveSig]
        HRESULT GetProcedureAddress(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStr)] string name, /* [annotation] _Outptr_ */ out IntPtr address);
    }
}
