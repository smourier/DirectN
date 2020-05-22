// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmsbuffer.h(698,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("61103ca4-2033-11d2-9ef1-006097d2d7cf"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMSBufferAllocator
    {
        [PreserveSig]
        HRESULT AllocateBuffer(/* [in] */ uint dwMaxBufferSize, /* [out] */ out INSSBuffer ppBuffer);
        
        [PreserveSig]
        HRESULT AllocatePageSizeBuffer(/* [in] */ uint dwMaxBufferSize, /* [out] */ out INSSBuffer ppBuffer);
    }
}
