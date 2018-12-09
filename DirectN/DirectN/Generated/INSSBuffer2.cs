// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wmsbuffer.h(246,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("4f528693-1035-43fe-b428-757561ad3a68"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface INSSBuffer2 : INSSBuffer
    {
        // INSSBuffer
        [PreserveSig]
        new HRESULT GetLength(/* [out] */ out uint pdwLength);
        
        [PreserveSig]
        new HRESULT SetLength(/* [in] */ uint dwLength);
        
        [PreserveSig]
        new HRESULT GetMaxLength(/* [out] */ out uint pdwLength);
        
        [PreserveSig]
        new HRESULT GetBuffer(/* [out] */ out IntPtr ppdwBuffer);
        
        [PreserveSig]
        new HRESULT GetBufferAndLength(/* [out] */ out IntPtr ppdwBuffer, /* [out] */ out uint pdwLength);
        
        // INSSBuffer2
        [PreserveSig]
        HRESULT GetSampleProperties(/* [in] */ uint cbProperties, /* [out] */ out byte pbProperties);
        
        [PreserveSig]
        HRESULT SetSampleProperties(/* [in] */ uint cbProperties, /* [in] */ ref byte pbProperties);
    }
}
