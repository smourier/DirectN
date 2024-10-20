// generated from <Windows SDK Path>\um\audioengineextensionapo.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("51cbd3c4-f1f3-4d2f-a0e1-7e9c4dd0feb3"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioProcessingObjectPreferredFormatSupport
    {
        [PreserveSig]
        HRESULT GetPreferredInputFormat(/* [in] */ IAudioMediaType outputFormat, /* [out] */ out IAudioMediaType preferredFormat);
        
        [PreserveSig]
        HRESULT GetPreferredOutputFormat(/* [in] */ IAudioMediaType inputFormat, /* [out] */ out IAudioMediaType preferredFormat);
    }
}
