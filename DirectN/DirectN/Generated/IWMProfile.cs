// generated from <Windows SDK Path>\um\wmsdkidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("96406bdb-2b2b-11d3-b36b-00c04f6108ff"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMProfile
    {
        [PreserveSig]
        HRESULT GetVersion(/* [out] */ out WMT_VERSION pdwVersion);
        
        [PreserveSig]
        HRESULT GetName(/* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszName, /* [out][in] */ ref uint pcchName);
        
        [PreserveSig]
        HRESULT SetName(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszName);
        
        [PreserveSig]
        HRESULT GetDescription(/* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszDescription, /* [out][in] */ ref uint pcchDescription);
        
        [PreserveSig]
        HRESULT SetDescription(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszDescription);
        
        [PreserveSig]
        HRESULT GetStreamCount(/* [out] */ out uint pcStreams);
        
        [PreserveSig]
        HRESULT GetStream(/* [in] */ uint dwStreamIndex, /* [out] */ out IWMStreamConfig ppConfig);
        
        [PreserveSig]
        HRESULT GetStreamByNumber(/* [in] */ ushort wStreamNum, /* [out] */ out IWMStreamConfig ppConfig);
        
        [PreserveSig]
        HRESULT RemoveStream(/* [in] */ IWMStreamConfig pConfig);
        
        [PreserveSig]
        HRESULT RemoveStreamByNumber(/* [in] */ ushort wStreamNum);
        
        [PreserveSig]
        HRESULT AddStream(/* [in] */ IWMStreamConfig pConfig);
        
        [PreserveSig]
        HRESULT ReconfigStream(/* [in] */ IWMStreamConfig pConfig);
        
        [PreserveSig]
        HRESULT CreateNewStream(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidStreamType, /* [out] */ out IWMStreamConfig ppConfig);
        
        [PreserveSig]
        HRESULT GetMutualExclusionCount(/* [out] */ out uint pcME);
        
        [PreserveSig]
        HRESULT GetMutualExclusion(/* [in] */ uint dwMEIndex, /* [out] */ out IWMMutualExclusion ppME);
        
        [PreserveSig]
        HRESULT RemoveMutualExclusion(/* [in] */ IWMMutualExclusion pME);
        
        [PreserveSig]
        HRESULT AddMutualExclusion(/* [in] */ IWMMutualExclusion pME);
        
        [PreserveSig]
        HRESULT CreateNewMutualExclusion(/* [out] */ out IWMMutualExclusion ppME);
    }
}
