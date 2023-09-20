// generated from <Windows SDK Path>\um\wmsdkidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("96406bdd-2b2b-11d3-b36b-00c04f6108ff"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMStreamList
    {
        [PreserveSig]
        HRESULT GetStreams(/* [size_is][out] */ [Out, MarshalAs(UnmanagedType.LPArray)] ushort[] pwStreamNumArray, /* [out][in] */ ref ushort pcStreams);
        
        [PreserveSig]
        HRESULT AddStream(/* [in] */ ushort wStreamNum);
        
        [PreserveSig]
        HRESULT RemoveStream(/* [in] */ ushort wStreamNum);
    }
}
