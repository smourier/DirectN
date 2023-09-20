// generated from <Windows SDK Path>\um\mfidl.h
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
