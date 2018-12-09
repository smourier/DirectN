// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wmsdkidl.h(6381,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("07e72d33-d94e-4be7-8843-60ae5ff7e5f5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMProfile2 : IWMProfile
    {
        // IWMProfile
        [PreserveSig]
        new HRESULT GetVersion(/* [out] */ out WMT_VERSION pdwVersion);
        
        [PreserveSig]
        new HRESULT GetName(/* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszName, /* [out][in] */ ref uint pcchName);
        
        [PreserveSig]
        new HRESULT SetName(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszName);
        
        [PreserveSig]
        new HRESULT GetDescription(/* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszDescription, /* [out][in] */ ref uint pcchDescription);
        
        [PreserveSig]
        new HRESULT SetDescription(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszDescription);
        
        [PreserveSig]
        new HRESULT GetStreamCount(/* [out] */ out uint pcStreams);
        
        [PreserveSig]
        new HRESULT GetStream(/* [in] */ uint dwStreamIndex, /* [out] */ out IWMStreamConfig ppConfig);
        
        [PreserveSig]
        new HRESULT GetStreamByNumber(/* [in] */ ushort wStreamNum, /* [out] */ out IWMStreamConfig ppConfig);
        
        [PreserveSig]
        new HRESULT RemoveStream(/* [in] */ IWMStreamConfig pConfig);
        
        [PreserveSig]
        new HRESULT RemoveStreamByNumber(/* [in] */ ushort wStreamNum);
        
        [PreserveSig]
        new HRESULT AddStream(/* [in] */ IWMStreamConfig pConfig);
        
        [PreserveSig]
        new HRESULT ReconfigStream(/* [in] */ IWMStreamConfig pConfig);
        
        [PreserveSig]
        new HRESULT CreateNewStream(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidStreamType, /* [out] */ out IWMStreamConfig ppConfig);
        
        [PreserveSig]
        new HRESULT GetMutualExclusionCount(/* [out] */ out uint pcME);
        
        [PreserveSig]
        new HRESULT GetMutualExclusion(/* [in] */ uint dwMEIndex, /* [out] */ out IWMMutualExclusion ppME);
        
        [PreserveSig]
        new HRESULT RemoveMutualExclusion(/* [in] */ IWMMutualExclusion pME);
        
        [PreserveSig]
        new HRESULT AddMutualExclusion(/* [in] */ IWMMutualExclusion pME);
        
        [PreserveSig]
        new HRESULT CreateNewMutualExclusion(/* [out] */ out IWMMutualExclusion ppME);
        
        // IWMProfile2
        [PreserveSig]
        HRESULT GetProfileID(/* [out] */ out Guid pguidID);
    }
}
