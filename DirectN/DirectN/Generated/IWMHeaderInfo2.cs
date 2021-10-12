// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmsdkidl.h(5410,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("15cf9781-454e-482e-b393-85fae487a810"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMHeaderInfo2 : IWMHeaderInfo
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
        HRESULT GetCodecInfoCount(/* [out] */ out uint pcCodecInfos);
        
        [PreserveSig]
        HRESULT GetCodecInfo(/* [in] */ uint wIndex, /* [out][in] */ ref ushort pcchName, /* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszName, /* [out][in] */ ref ushort pcchDescription, /* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszDescription, /* [out] */ out WMT_CODEC_INFO_TYPE pCodecType, /* [out][in] */ ref ushort pcbCodecInfo, /* [size_is][out] */ [Out, MarshalAs(UnmanagedType.LPArray)] byte[] pbCodecInfo);
    }
}
