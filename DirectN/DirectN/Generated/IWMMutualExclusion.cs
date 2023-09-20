// generated from <Windows SDK Path>\um\wmsdkidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("96406bde-2b2b-11d3-b36b-00c04f6108ff"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
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
