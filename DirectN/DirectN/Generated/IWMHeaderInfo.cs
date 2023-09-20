// generated from <Windows SDK Path>\um\wmsdkidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("96406bda-2b2b-11d3-b36b-00c04f6108ff"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMHeaderInfo
    {
        [PreserveSig]
        HRESULT GetAttributeCount(/* [in] */ ushort wStreamNum, /* [out] */ out ushort pcAttributes);
        
        [PreserveSig]
        HRESULT GetAttributeByIndex(/* [in] */ ushort wIndex, /* [out][in] */ ref ushort pwStreamNum, /* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszName, /* [out][in] */ ref ushort pcchNameLen, /* [out] */ out WMT_ATTR_DATATYPE pType, /* [size_is][out] */ [Out, MarshalAs(UnmanagedType.LPArray)] byte[] pValue, /* [out][in] */ ref ushort pcbLength);
        
        [PreserveSig]
        HRESULT GetAttributeByName(/* [out][in] */ ref ushort pwStreamNum, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pszName, /* [out] */ out WMT_ATTR_DATATYPE pType, /* [size_is][out] */ [Out, MarshalAs(UnmanagedType.LPArray)] byte[] pValue, /* [out][in] */ ref ushort pcbLength);
        
        [PreserveSig]
        HRESULT SetAttribute(/* [in] */ ushort wStreamNum, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pszName, /* [in] */ WMT_ATTR_DATATYPE Type, /* [size_is][in] */ [MarshalAs(UnmanagedType.LPArray)] byte[] pValue, /* [in] */ ushort cbLength);
        
        [PreserveSig]
        HRESULT GetMarkerCount(/* [out] */ out ushort pcMarkers);
        
        [PreserveSig]
        HRESULT GetMarker(/* [in] */ ushort wIndex, /* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszMarkerName, /* [out][in] */ ref ushort pcchMarkerNameLen, /* [out] */ out ulong pcnsMarkerTime);
        
        [PreserveSig]
        HRESULT AddMarker(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszMarkerName, /* [in] */ ulong cnsMarkerTime);
        
        [PreserveSig]
        HRESULT RemoveMarker(/* [in] */ ushort wIndex);
        
        [PreserveSig]
        HRESULT GetScriptCount(/* [out] */ out ushort pcScripts);
        
        [PreserveSig]
        HRESULT GetScript(/* [in] */ ushort wIndex, /* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszType, /* [out][in] */ ref ushort pcchTypeLen, /* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszCommand, /* [out][in] */ ref ushort pcchCommandLen, /* [out] */ out ulong pcnsScriptTime);
        
        [PreserveSig]
        HRESULT AddScript(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszType, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszCommand, /* [in] */ ulong cnsScriptTime);
        
        [PreserveSig]
        HRESULT RemoveScript(/* [in] */ ushort wIndex);
    }
}
