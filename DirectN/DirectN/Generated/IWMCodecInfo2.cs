// generated from <Windows SDK Path>\um\wmsdkidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("aa65e273-b686-4056-91ec-dd768d4df710"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMCodecInfo2 : IWMCodecInfo
    {
        // IWMCodecInfo
        [PreserveSig]
        new HRESULT GetCodecInfoCount(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidType, /* [out] */ out uint pcCodecs);
        
        [PreserveSig]
        new HRESULT GetCodecFormatCount(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidType, /* [in] */ uint dwCodecIndex, /* [out] */ out uint pcFormat);
        
        [PreserveSig]
        new HRESULT GetCodecFormat(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidType, /* [in] */ uint dwCodecIndex, /* [in] */ uint dwFormatIndex, /* [out] */ out IWMStreamConfig ppIStreamConfig);
        
        // IWMCodecInfo2
        [PreserveSig]
        HRESULT GetCodecName(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidType, /* [in] */ uint dwCodecIndex, /* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string wszName, /* [out][in] */ ref uint pcchName);
        
        [PreserveSig]
        HRESULT GetCodecFormatDesc(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidType, /* [in] */ uint dwCodecIndex, /* [in] */ uint dwFormatIndex, /* [out] */ out IWMStreamConfig ppIStreamConfig, /* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string wszDesc, /* [out][in] */ ref uint pcchDesc);
    }
}
