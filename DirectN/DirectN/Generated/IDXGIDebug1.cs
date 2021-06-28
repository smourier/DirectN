// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dxgidebug.h(876,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("c5a05f0c-16f2-4adf-9f4d-a8c4d58ac550"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDXGIDebug1 : IDXGIDebug
    {
        // IDXGIDebug
        [PreserveSig]
        new HRESULT ReportLiveObjects(Guid apiid, DXGI_DEBUG_RLO_FLAGS flags);
        
        // IDXGIDebug1
        [PreserveSig]
        void EnableLeakTrackingForThread();
        
        [PreserveSig]
        void DisableLeakTrackingForThread();
        
        [PreserveSig]
        bool IsLeakTrackingEnabledForThread();
    }
}
