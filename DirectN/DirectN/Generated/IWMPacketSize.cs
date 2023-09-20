// generated from <Windows SDK Path>\um\wmsdkidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("cdfb97ab-188f-40b3-b643-5b7903975c59"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPacketSize
    {
        [PreserveSig]
        HRESULT GetMaxPacketSize(/* [out] */ out uint pdwMaxPacketSize);
        
        [PreserveSig]
        HRESULT SetMaxPacketSize(/* [in] */ uint dwMaxPacketSize);
    }
}
