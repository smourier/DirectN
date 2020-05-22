// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmcontainer.h(1376,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("699bdc27-bbaf-49ff-8e38-9c39c9b5e088"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
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
