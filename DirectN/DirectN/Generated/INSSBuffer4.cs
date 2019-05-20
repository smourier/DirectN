// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wmsbuffer.h(529,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("b6b8fd5a-32e2-49d4-a910-c26cc85465ed"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface INSSBuffer4 : INSSBuffer3
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
        new HRESULT GetSampleProperties(/* [in] */ uint cbProperties, /* [out] */ out byte pbProperties);
        
        [PreserveSig]
        new HRESULT SetSampleProperties(/* [in] */ uint cbProperties, /* [in] */ ref byte pbProperties);
        
        // INSSBuffer3
        [PreserveSig]
        new HRESULT SetProperty(/* [in] */ Guid guidBufferProperty, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pvBufferProperty, /* [in] */ uint dwBufferPropertySize);
        
        [PreserveSig]
        new HRESULT GetProperty(/* [in] */ Guid guidBufferProperty, /* [out] */ [MarshalAs(UnmanagedType.IUnknown)] out object pvBufferProperty, /* [out][in] */ ref uint pdwBufferPropertySize);
        
        // INSSBuffer4
        [PreserveSig]
        HRESULT GetPropertyCount(/* [out] */ out uint pcBufferProperties);
        
        [PreserveSig]
        HRESULT GetPropertyByIndex(/* [in] */ uint dwBufferPropertyIndex, /* [out] */ out Guid pguidBufferProperty, /* [out] */ [MarshalAs(UnmanagedType.IUnknown)] out object pvBufferProperty, /* [out][in] */ ref uint pdwBufferPropertySize);
    }
}
