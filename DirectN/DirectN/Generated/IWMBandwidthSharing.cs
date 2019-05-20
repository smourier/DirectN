// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wmsdkidl.h(8186,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("ad694af1-f8d9-42f8-bc47-70311b0c4f9e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMBandwidthSharing : IWMStreamList
    {
        // IWMStreamList
        [PreserveSig]
        new HRESULT GetStreams(/* [size_is][out] */ [Out, MarshalAs(UnmanagedType.LPArray)] ushort[] pwStreamNumArray, /* [out][in] */ ref ushort pcStreams);
        
        [PreserveSig]
        new HRESULT AddStream(/* [in] */ ushort wStreamNum);
        
        [PreserveSig]
        new HRESULT RemoveStream(/* [in] */ ushort wStreamNum);
        
        // IWMBandwidthSharing
        [PreserveSig]
        HRESULT GetType(/* [out] */ out Guid pguidType);
        
        [PreserveSig]
        HRESULT SetType(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidType);
        
        [PreserveSig]
        HRESULT GetBandwidth(/* [out] */ out uint pdwBitrate, /* [out] */ out uint pmsBufferWindow);
        
        [PreserveSig]
        HRESULT SetBandwidth(/* [in] */ uint dwBitrate, /* [in] */ uint msBufferWindow);
    }
}
