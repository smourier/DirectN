// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("26afea53-d9ed-42b5-ab80-e64f9ee34779"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSeekInfo
    {
        [PreserveSig]
        HRESULT GetNearestKeyFrames(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pguidTimeFormat, /* [annotation][in] _In_ */ [In, Out] PROPVARIANT pvarStartPosition, /* [annotation][out] _Out_ */ [In, Out] PROPVARIANT pvarPreviousKeyFrame, /* [annotation][out] _Out_ */ [In, Out] PROPVARIANT pvarNextKeyFrame);
    }
}
