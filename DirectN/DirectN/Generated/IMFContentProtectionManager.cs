// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfidl.h(7239,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("acf92459-6a61-42bd-b57c-b43e51203cb0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFContentProtectionManager
    {
        [PreserveSig]
        HRESULT BeginEnableContent(/* [in] */ IMFActivate pEnablerActivate, /* [in] */ IMFTopology pTopo, /* [in] */ IMFAsyncCallback pCallback, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object punkState);
        
        [PreserveSig]
        HRESULT EndEnableContent(/* [in] */ IMFAsyncResult pResult);
    }
}
