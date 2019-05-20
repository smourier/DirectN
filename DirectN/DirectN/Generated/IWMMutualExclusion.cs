// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wmsdkidl.h(7851,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("96406bde-2b2b-11d3-b36b-00c04f6108ff"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMMutualExclusion : IWMStreamList
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
        HRESULT GetType(/* [out] */ out Guid pguidType);
        
        [PreserveSig]
        HRESULT SetType(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidType);
    }
}
