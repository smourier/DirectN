// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("e9cd0384-a268-4bb4-82de-658d53574d41"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFNetProxyLocatorFactory
    {
        [PreserveSig]
        HRESULT CreateProxyLocator(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pszProtocol, /* [annotation][out] _Outptr_ */ out IMFNetProxyLocator ppProxyLocator);
    }
}
