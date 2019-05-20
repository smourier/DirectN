// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wmsdkidl.h(15643,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("a970f41e-34de-4a98-b3ba-e4b3ca7528f0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
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
