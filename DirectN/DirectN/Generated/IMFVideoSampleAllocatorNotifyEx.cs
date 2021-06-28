// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfidl.h(2900,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("3978aa1a-6d5b-4b7f-a340-90899189ae34"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFVideoSampleAllocatorNotifyEx : IMFVideoSampleAllocatorNotify
    {
        // IMFVideoSampleAllocatorNotify
        [PreserveSig]
        new HRESULT NotifyRelease();
        
        // IMFVideoSampleAllocatorNotifyEx
        [PreserveSig]
        HRESULT NotifyPrune(IMFSample __MIDL__IMFVideoSampleAllocatorNotifyEx0000);
    }
}
