// generated from <Windows SDK Path>\um\wmcodecdsp.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("9bca9884-0604-4c2a-87da-793ff4d586c3"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMSampleExtensionSupport
    {
        [PreserveSig]
        HRESULT SetUseSampleExtensions(bool fUseExtensions);
    }
}
