// generated from <Windows SDK Path>\um\wmsbuffer.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("61103ca4-2033-11d2-9ef1-006097d2d7cf"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMSBufferAllocator
    {
        [PreserveSig]
        HRESULT AllocateBuffer(/* [in] */ uint dwMaxBufferSize, /* [out] */ out INSSBuffer ppBuffer);
        
        [PreserveSig]
        HRESULT AllocatePageSizeBuffer(/* [in] */ uint dwMaxBufferSize, /* [out] */ out INSSBuffer ppBuffer);
    }
}
