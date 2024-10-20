// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("0bfd1ade-0421-4909-acb7-7a7125416881"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFFaceDetectionTransformCallback
    {
        [PreserveSig]
        void OnFaceDetectionResult(/* [annotation][in] _In_ */ int countOfBounds, /* [annotation][in] _In_reads_(countOfBounds) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] __MIDL___MIDL_itf_mfidl_0000_0139_0001[] detectedFaceBounds);
    }
}
