// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmsdkidl.h(7959,5)
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
