// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wmsbuffer.h(124,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("e1cd3524-03d7-11d2-9eed-006097d2d7cf"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface INSSBuffer
    {
        [PreserveSig]
        HRESULT GetLength(/* [out] */ out uint pdwLength);
        
        [PreserveSig]
        HRESULT SetLength(/* [in] */ uint dwLength);
        
        [PreserveSig]
        HRESULT GetMaxLength(/* [out] */ out uint pdwLength);
        
        [PreserveSig]
        HRESULT GetBuffer(/* [out] */ out IntPtr ppdwBuffer);
        
        [PreserveSig]
        HRESULT GetBufferAndLength(/* [out] */ out IntPtr ppdwBuffer, /* [out] */ out uint pdwLength);
    }
}
