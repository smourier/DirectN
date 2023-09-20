// generated from <Windows SDK Path>\um\wmsdkidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("a970f41e-34de-4a98-b3ba-e4b3ca7528f0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMCodecInfo
    {
        [PreserveSig]
        HRESULT GetCodecInfoCount(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidType, /* [out] */ out uint pcCodecs);
        
        [PreserveSig]
        HRESULT GetCodecFormatCount(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidType, /* [in] */ uint dwCodecIndex, /* [out] */ out uint pcFormat);
        
        [PreserveSig]
        HRESULT GetCodecFormat(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidType, /* [in] */ uint dwCodecIndex, /* [in] */ uint dwFormatIndex, /* [out] */ out IWMStreamConfig ppIStreamConfig);
    }
}
