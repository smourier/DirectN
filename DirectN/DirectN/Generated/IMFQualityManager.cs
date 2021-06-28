// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfidl.h(9726,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("8d009d86-5b9f-4115-b1fc-9f80d52ab8ab"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFQualityManager
    {
        [PreserveSig]
        HRESULT NotifyTopology(/* [in] */ IMFTopology pTopology);
        
        [PreserveSig]
        HRESULT NotifyPresentationClock(/* [in] */ IMFPresentationClock pClock);
        
        [PreserveSig]
        HRESULT NotifyProcessInput(/* [in] */ IMFTopologyNode pNode, /* [in] */ int lInputIndex, /* [in] */ IMFSample pSample);
        
        [PreserveSig]
        HRESULT NotifyProcessOutput(/* [in] */ IMFTopologyNode pNode, /* [in] */ int lOutputIndex, /* [in] */ IMFSample pSample);
        
        [PreserveSig]
        HRESULT NotifyQualityEvent(/* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pObject, /* [in] */ IMFMediaEvent pEvent);
        
        [PreserveSig]
        HRESULT Shutdown();
    }
}
