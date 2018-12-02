// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\audiomediatype.h(95,5)
using System;
using System.Runtime.InteropServices;
using WAVEFORMATEX = DirectN.tWAVEFORMATEX;

namespace DirectN
{
    [Guid("4e997f73-b71f-4798-873b-ed7dfcf15b4d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioMediaType
    {
        [PreserveSig]
        HRESULT IsCompressedFormat(/* [annotation][out] _Out_ */ out bool pfCompressed);
        
        [PreserveSig]
        HRESULT IsEqual(/* [annotation][in] _In_ */ IAudioMediaType pIAudioType, /* [annotation][out] _Out_ */ out uint pdwFlags);
        
        [PreserveSig]
        WAVEFORMATEX GetAudioFormat();
        
        [PreserveSig]
        HRESULT GetUncompressedAudioFormat(/* [annotation][out] _Out_ */ out _UNCOMPRESSEDAUDIOFORMAT pUncompressedAudioFormat);
    }
}
