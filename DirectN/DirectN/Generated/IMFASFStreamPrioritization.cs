// generated from <Windows SDK Path>\um\wmcontainer.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("699bdc27-bbaf-49ff-8e38-9c39c9b5e088"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFASFStreamPrioritization
    {
        [PreserveSig]
        HRESULT GetStreamCount(/* [out] */ out uint pdwStreamCount);
        
        [PreserveSig]
        HRESULT GetStream(/* [in] */ uint dwStreamIndex, /* [out] */ out ushort pwStreamNumber, /* [out] */ out ushort pwStreamFlags);
        
        [PreserveSig]
        HRESULT AddStream(/* [in] */ ushort wStreamNumber, /* [in] */ ushort wStreamFlags);
        
        [PreserveSig]
        HRESULT RemoveStream(/* [in] */ uint dwStreamIndex);
        
        [PreserveSig]
        HRESULT Clone(/* [out] */ out IMFASFStreamPrioritization ppIStreamPrioritization);
    }
}
