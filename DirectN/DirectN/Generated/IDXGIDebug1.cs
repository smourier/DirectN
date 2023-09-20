// generated from <Windows SDK Path>\um\dxgidebug.h
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
