// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wmsdkidl.h(7964,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("0302b57d-89d1-4ba2-85c9-166f2c53eb91"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMMutualExclusion2 : IWMMutualExclusion
    {
        // IWMStreamList
        [PreserveSig]
        new HRESULT GetStreams(/* [size_is][out] */ [Out, MarshalAs(UnmanagedType.LPArray)] ushort[] pwStreamNumArray, /* [out][in] */ ref ushort pcStreams);
        
        [PreserveSig]
        new HRESULT AddStream(/* [in] */ ushort wStreamNum);
        
        [PreserveSig]
        new HRESULT RemoveStream(/* [in] */ ushort wStreamNum);
        
        // IWMMutualExclusion
        [PreserveSig]
        new HRESULT GetType(/* [out] */ out Guid pguidType);
        
        [PreserveSig]
        new HRESULT SetType(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidType);
        
        // IWMMutualExclusion2
        [PreserveSig]
        HRESULT GetName(/* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszName, /* [out][in] */ ref ushort pcchName);
        
        [PreserveSig]
        HRESULT SetName(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszName);
        
        [PreserveSig]
        HRESULT GetRecordCount(/* [out] */ out ushort pwRecordCount);
        
        [PreserveSig]
        HRESULT AddRecord();
        
        [PreserveSig]
        HRESULT RemoveRecord(/* [in] */ ushort wRecordNumber);
        
        [PreserveSig]
        HRESULT GetRecordName(/* [in] */ ushort wRecordNumber, /* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszRecordName, /* [out][in] */ ref ushort pcchRecordName);
        
        [PreserveSig]
        HRESULT SetRecordName(/* [in] */ ushort wRecordNumber, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszRecordName);
        
        [PreserveSig]
        HRESULT GetStreamsForRecord(/* [in] */ ushort wRecordNumber, /* [size_is][out] */ [Out, MarshalAs(UnmanagedType.LPArray)] ushort[] pwStreamNumArray, /* [out][in] */ ref ushort pcStreams);
        
        [PreserveSig]
        HRESULT AddStreamForRecord(/* [in] */ ushort wRecordNumber, /* [in] */ ushort wStreamNumber);
        
        [PreserveSig]
        HRESULT RemoveStreamForRecord(/* [in] */ ushort wRecordNumber, /* [in] */ ushort wStreamNumber);
    }
}
