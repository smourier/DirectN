// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wmsbuffer.h(377,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("c87ceaaf-75be-4bc4-84eb-ac2798507672"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface INSSBuffer3 : INSSBuffer2
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
        HRESULT SetProperty(/* [in] */ Guid guidBufferProperty, /* [in] */ IntPtr pvBufferProperty, /* [in] */ uint dwBufferPropertySize);
        
        [PreserveSig]
        HRESULT GetProperty(/* [in] */ Guid guidBufferProperty, /* [out] */ out IntPtr pvBufferProperty, /* [out][in] */ ref uint pdwBufferPropertySize);
    }
}
