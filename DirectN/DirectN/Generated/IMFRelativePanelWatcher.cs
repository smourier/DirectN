// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfidl.h(21308,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("421af7f6-573e-4ad0-8fda-2e57cedb18c6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFRelativePanelWatcher : IMFShutdown
    {
        // IMFShutdown
        [PreserveSig]
        new HRESULT Shutdown();
        
        [PreserveSig]
        new HRESULT GetShutdownStatus(/* [out] __RPC__out */ out _MFSHUTDOWN_STATUS pStatus);
        
        // IMFRelativePanelWatcher
        [PreserveSig]
        HRESULT BeginGetReport(/* [annotation][in] _In_ */ IMFAsyncCallback pCallback, /* [annotation][in] _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object pState);
        
        [PreserveSig]
        HRESULT EndGetReport(/* [annotation][in] _In_ */ IMFAsyncResult pResult, /* [annotation][out] _COM_Outptr_ */ out IMFRelativePanelReport ppRelativePanelReport);
        
        [PreserveSig]
        HRESULT GetReport(/* [annotation][out] _COM_Outptr_ */ out IMFRelativePanelReport ppRelativePanelReport);
    }
}
