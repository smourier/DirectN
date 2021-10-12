// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfidl.h(22658,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("1640b2cf-74da-4462-a43b-b76d3bdc1434"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFCameraOcclusionStateReport
    {
        [PreserveSig]
        HRESULT GetOcclusionState(/* [annotation][out] _Out_ */ out uint occlusionState);
    }
}
