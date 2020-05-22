// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfmediaengine.h(7752,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("ad128745-211b-40a0-9981-fe65f166d0fd"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFTimedTextCueList
    {
        [PreserveSig]
        uint GetLength();
        
        [PreserveSig]
        HRESULT GetCueByIndex(/* [annotation][in] _In_ */ uint index, /* [annotation][out] _COM_Outptr_ */ out IMFTimedTextCue cue);
        
        [PreserveSig]
        HRESULT GetCueById(/* [annotation][in] _In_ */ uint id, /* [annotation][out] _COM_Outptr_ */ out IMFTimedTextCue cue);
        
        [PreserveSig]
        HRESULT GetCueByOriginalId(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string originalId, /* [annotation][out] _COM_Outptr_ */ out IMFTimedTextCue cue);
        
        [PreserveSig]
        HRESULT AddTextCue(/* [annotation][in] _In_ */ double start, /* [annotation][in] _In_ */ double duration, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string text, /* [annotation][out] _COM_Outptr_opt_ */ out IMFTimedTextCue cue);
        
        [PreserveSig]
        HRESULT AddDataCue(/* [annotation][in] _In_ */ double start, /* [annotation][in] _In_ */ double duration, /* [annotation][in] _In_reads_bytes_(dataSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] byte[] data, /* [annotation][in] _In_ */ int dataSize, /* [annotation][out] _COM_Outptr_opt_ */ out IMFTimedTextCue cue);
        
        [PreserveSig]
        HRESULT RemoveCue(/* [annotation][in] _In_ */ IMFTimedTextCue cue);
    }
}
