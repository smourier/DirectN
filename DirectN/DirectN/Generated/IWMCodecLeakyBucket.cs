// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wmcodecdsp.h(1969,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("a81ba647-6227-43b7-b231-c7b15135dd7d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMCodecLeakyBucket
    {
        [PreserveSig]
        HRESULT SetBufferSizeBits(/* [in] */ uint ulBufferSize);
        
        [PreserveSig]
        HRESULT GetBufferSizeBits(/* [out] */ out uint pulBufferSize);
        
        [PreserveSig]
        HRESULT SetBufferFullnessBits(/* [in] */ uint ulBufferFullness);
        
        [PreserveSig]
        HRESULT GetBufferFullnessBits(/* [out] */ out uint pulBufferFullness);
    }
}
