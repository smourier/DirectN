// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmsdkidl.h(15889,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("7e51f487-4d93-4f98-8ab4-27d0565adc51"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMCodecInfo3 : IWMCodecInfo2
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
        new HRESULT GetCodecName(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidType, /* [in] */ uint dwCodecIndex, /* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string wszName, /* [out][in] */ ref uint pcchName);
        
        [PreserveSig]
        new HRESULT GetCodecFormatDesc(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidType, /* [in] */ uint dwCodecIndex, /* [in] */ uint dwFormatIndex, /* [out] */ out IWMStreamConfig ppIStreamConfig, /* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string wszDesc, /* [out][in] */ ref uint pcchDesc);
        
        // IWMCodecInfo3
        [PreserveSig]
        HRESULT GetCodecFormatProp(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidType, /* [in] */ uint dwCodecIndex, /* [in] */ uint dwFormatIndex, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pszName, /* [out] */ out WMT_ATTR_DATATYPE pType, /* [size_is][out] */ [Out, MarshalAs(UnmanagedType.LPArray)] byte[] pValue, /* [out][in] */ ref uint pdwSize);
        
        [PreserveSig]
        HRESULT GetCodecProp(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidType, /* [in] */ uint dwCodecIndex, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pszName, /* [out] */ out WMT_ATTR_DATATYPE pType, /* [size_is][out] */ [Out, MarshalAs(UnmanagedType.LPArray)] byte[] pValue, /* [out][in] */ ref uint pdwSize);
        
        [PreserveSig]
        HRESULT SetCodecEnumerationSetting(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidType, /* [in] */ uint dwCodecIndex, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pszName, /* [in] */ WMT_ATTR_DATATYPE Type, /* [size_is][in] */ [MarshalAs(UnmanagedType.LPArray)] byte[] pValue, /* [in] */ uint dwSize);
        
        [PreserveSig]
        HRESULT GetCodecEnumerationSetting(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidType, /* [in] */ uint dwCodecIndex, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pszName, /* [out] */ out WMT_ATTR_DATATYPE pType, /* [size_is][out] */ [Out, MarshalAs(UnmanagedType.LPArray)] byte[] pValue, /* [out][in] */ ref uint pdwSize);
    }
}
