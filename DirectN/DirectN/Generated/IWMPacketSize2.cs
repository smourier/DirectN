// generated from <Windows SDK Path>\um\wmsdkidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("8bfc2b9e-b646-4233-a877-1c6a079669dc"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPacketSize2 : IWMPacketSize
    {
        // IWMPacketSize
        [PreserveSig]
        new HRESULT GetMaxPacketSize(/* [out] */ out uint pdwMaxPacketSize);
        
        [PreserveSig]
        new HRESULT SetMaxPacketSize(/* [in] */ uint dwMaxPacketSize);
        
        // IWMPacketSize2
        [PreserveSig]
        HRESULT GetMinPacketSize(/* [out] */ out uint pdwMinPacketSize);
        
        [PreserveSig]
        HRESULT SetMinPacketSize(/* [in] */ uint dwMinPacketSize);
    }
}
