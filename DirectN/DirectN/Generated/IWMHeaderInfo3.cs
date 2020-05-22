// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmsdkidl.h(5419,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("15cc68e3-27cc-4ecd-b222-3f5d02d80bd5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMHeaderInfo3 : IWMHeaderInfo2
    {
        // IWMHeaderInfo
        [PreserveSig]
        new HRESULT GetAttributeCount(/* [in] */ ushort wStreamNum, /* [out] */ out ushort pcAttributes);
        
        [PreserveSig]
        new HRESULT GetAttributeByIndex(/* [in] */ ushort wIndex, /* [out][in] */ ref ushort pwStreamNum, /* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszName, /* [out][in] */ ref ushort pcchNameLen, /* [out] */ out WMT_ATTR_DATATYPE pType, /* [size_is][out] */ [Out, MarshalAs(UnmanagedType.LPArray)] byte[] pValue, /* [out][in] */ ref ushort pcbLength);
        
        [PreserveSig]
        new HRESULT GetAttributeByName(/* [out][in] */ ref ushort pwStreamNum, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pszName, /* [out] */ out WMT_ATTR_DATATYPE pType, /* [size_is][out] */ [Out, MarshalAs(UnmanagedType.LPArray)] byte[] pValue, /* [out][in] */ ref ushort pcbLength);
        
        [PreserveSig]
        new HRESULT SetAttribute(/* [in] */ ushort wStreamNum, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pszName, /* [in] */ WMT_ATTR_DATATYPE Type, /* [size_is][in] */ [MarshalAs(UnmanagedType.LPArray)] byte[] pValue, /* [in] */ ushort cbLength);
        
        [PreserveSig]
        new HRESULT GetMarkerCount(/* [out] */ out ushort pcMarkers);
        
        [PreserveSig]
        new HRESULT GetMarker(/* [in] */ ushort wIndex, /* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszMarkerName, /* [out][in] */ ref ushort pcchMarkerNameLen, /* [out] */ out ulong pcnsMarkerTime);
        
        [PreserveSig]
        new HRESULT AddMarker(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszMarkerName, /* [in] */ ulong cnsMarkerTime);
        
        [PreserveSig]
        new HRESULT RemoveMarker(/* [in] */ ushort wIndex);
        
        [PreserveSig]
        new HRESULT GetScriptCount(/* [out] */ out ushort pcScripts);
        
        [PreserveSig]
        new HRESULT GetScript(/* [in] */ ushort wIndex, /* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszType, /* [out][in] */ ref ushort pcchTypeLen, /* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszCommand, /* [out][in] */ ref ushort pcchCommandLen, /* [out] */ out ulong pcnsScriptTime);
        
        [PreserveSig]
        new HRESULT AddScript(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszType, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszCommand, /* [in] */ ulong cnsScriptTime);
        
        [PreserveSig]
        new HRESULT RemoveScript(/* [in] */ ushort wIndex);
        
        // IWMHeaderInfo2
        [PreserveSig]
        new HRESULT GetCodecInfoCount(/* [out] */ out uint pcCodecInfos);
        
        [PreserveSig]
        new HRESULT GetCodecInfo(/* [in] */ uint wIndex, /* [out][in] */ ref ushort pcchName, /* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszName, /* [out][in] */ ref ushort pcchDescription, /* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszDescription, /* [out] */ out WMT_CODEC_INFO_TYPE pCodecType, /* [out][in] */ ref ushort pcbCodecInfo, /* [size_is][out] */ [Out, MarshalAs(UnmanagedType.LPArray)] byte[] pbCodecInfo);
        
        // IWMHeaderInfo3
        [PreserveSig]
        HRESULT GetAttributeCountEx(/* [in] */ ushort wStreamNum, /* [out] */ out ushort pcAttributes);
        
        [PreserveSig]
        HRESULT GetAttributeIndices(/* [in] */ ushort wStreamNum, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszName, /* [in] */ ref ushort pwLangIndex, /* [size_is][out] */ [Out, MarshalAs(UnmanagedType.LPArray)] ushort[] pwIndices, /* [out][in] */ ref ushort pwCount);
        
        [PreserveSig]
        HRESULT GetAttributeByIndexEx(/* [in] */ ushort wStreamNum, /* [in] */ ushort wIndex, /* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszName, /* [out][in] */ ref ushort pwNameLen, /* [out] */ out WMT_ATTR_DATATYPE pType, /* [out] */ out ushort pwLangIndex, /* [size_is][out] */ [Out, MarshalAs(UnmanagedType.LPArray)] byte[] pValue, /* [out][in] */ ref uint pdwDataLength);
        
        [PreserveSig]
        HRESULT ModifyAttribute(/* [in] */ ushort wStreamNum, /* [in] */ ushort wIndex, /* [in] */ WMT_ATTR_DATATYPE Type, /* [in] */ ushort wLangIndex, /* [size_is][in] */ [MarshalAs(UnmanagedType.LPArray)] byte[] pValue, /* [in] */ uint dwLength);
        
        [PreserveSig]
        HRESULT AddAttribute(/* [in] */ ushort wStreamNum, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pszName, /* [out] */ out ushort pwIndex, /* [in] */ WMT_ATTR_DATATYPE Type, /* [in] */ ushort wLangIndex, /* [size_is][in] */ [MarshalAs(UnmanagedType.LPArray)] byte[] pValue, /* [in] */ uint dwLength);
        
        [PreserveSig]
        HRESULT DeleteAttribute(/* [in] */ ushort wStreamNum, /* [in] */ ushort wIndex);
        
        [PreserveSig]
        HRESULT AddCodecInfo(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszName, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszDescription, /* [in] */ WMT_CODEC_INFO_TYPE codecType, /* [in] */ ushort cbCodecInfo, /* [size_is][in] */ [MarshalAs(UnmanagedType.LPArray)] byte[] pbCodecInfo);
    }
}
