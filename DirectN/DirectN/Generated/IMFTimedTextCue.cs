// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfmediaengine.h(6882,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("1e560447-9a2b-43e1-a94c-b0aaabfbfbc9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFTimedTextCue
    {
        [PreserveSig]
        uint GetId();
        
        [PreserveSig]
        HRESULT GetOriginalId(/* [annotation][out] _Outptr_ */ out IntPtr originalId);
        
        [PreserveSig]
        MF_TIMED_TEXT_TRACK_KIND GetCueKind();
        
        [PreserveSig]
        void GetStartTime();
        
        [PreserveSig]
        void GetDuration();
        
        [PreserveSig]
        uint GetTrackId();
        
        [PreserveSig]
        HRESULT GetData(/* [annotation][out] _COM_Outptr_result_maybenull_ */ out IMFTimedTextBinary data);
        
        [PreserveSig]
        HRESULT GetRegion(/* [annotation][out] _COM_Outptr_result_maybenull_ */ out IMFTimedTextRegion region);
        
        [PreserveSig]
        HRESULT GetStyle(/* [annotation][out] _COM_Outptr_result_maybenull_ */ out IMFTimedTextStyle style);
        
        [PreserveSig]
        uint GetLineCount();
        
        [PreserveSig]
        HRESULT GetLine(/* [annotation][in] _In_ */ uint index, /* [annotation][out] _COM_Outptr_ */ out IMFTimedTextFormattedText line);
    }
}
