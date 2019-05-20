// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\mfidl.h(8112,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("26afea53-d9ed-42b5-ab80-e64f9ee34779"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSeekInfo
    {
        [PreserveSig]
        HRESULT GetNearestKeyFrames(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pguidTimeFormat, /* [annotation][in] _In_ */ [In, Out] PropVariant pvarStartPosition, /* [annotation][out] _Out_ */ [In, Out] PropVariant pvarPreviousKeyFrame, /* [annotation][out] _Out_ */ [In, Out] PropVariant pvarNextKeyFrame);
    }
}
