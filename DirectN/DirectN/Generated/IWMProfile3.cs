// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmsdkidl.h(6909,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("00ef96cc-a461-4546-8bcd-c9a28f0e06f5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMProfile3 : IWMProfile2
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
        new HRESULT GetProfileID(/* [out] */ out Guid pguidID);
        
        // IWMProfile3
        [PreserveSig]
        HRESULT GetStorageFormat(/* [out] */ out tagWMT_STORAGE_FORMAT pnStorageFormat);
        
        [PreserveSig]
        HRESULT SetStorageFormat(/* [in] */ tagWMT_STORAGE_FORMAT nStorageFormat);
        
        [PreserveSig]
        HRESULT GetBandwidthSharingCount(/* [out] */ out uint pcBS);
        
        [PreserveSig]
        HRESULT GetBandwidthSharing(/* [in] */ uint dwBSIndex, /* [out] */ out IWMBandwidthSharing ppBS);
        
        [PreserveSig]
        HRESULT RemoveBandwidthSharing(/* [in] */ IWMBandwidthSharing pBS);
        
        [PreserveSig]
        HRESULT AddBandwidthSharing(/* [in] */ IWMBandwidthSharing pBS);
        
        [PreserveSig]
        HRESULT CreateNewBandwidthSharing(/* [out] */ out IWMBandwidthSharing ppBS);
        
        [PreserveSig]
        HRESULT GetStreamPrioritization(/* [out] */ out IWMStreamPrioritization ppSP);
        
        [PreserveSig]
        HRESULT SetStreamPrioritization(/* [in] */ IWMStreamPrioritization pSP);
        
        [PreserveSig]
        HRESULT RemoveStreamPrioritization();
        
        [PreserveSig]
        HRESULT CreateNewStreamPrioritization(/* [out] */ out IWMStreamPrioritization ppSP);
        
        [PreserveSig]
        HRESULT GetExpectedPacketCount(/* [in] */ ulong msDuration, /* [out] */ out ulong pcPackets);
    }
}
