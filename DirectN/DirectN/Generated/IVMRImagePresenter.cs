// c:\program files (x86)\windows kits\10\include\10.0.22621.0\um\strmif.h(19534,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("ce704fe7-e71e-41fb-baa2-c4403e1182f5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IVMRImagePresenter
    {
        [PreserveSig]
        HRESULT StartPresenting(/* [in] */ IntPtr dwUserID);
        
        [PreserveSig]
        HRESULT StopPresenting(/* [in] */ IntPtr dwUserID);
        
        [PreserveSig]
        HRESULT PresentImage(/* [in] */ IntPtr dwUserID, /* [in] */ ref tagVMRPRESENTATIONINFO lpPresInfo);
    }
}
