// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfidl.h(22744,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("6e5841c7-3889-4019-9035-783fb19b5948"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFCameraOcclusionStateReportCallback
    {
        [PreserveSig]
        HRESULT OnOcclusionStateReport(/* [annotation][in] _In_ */ IMFCameraOcclusionStateReport occlusionStateReport);
    }
}
