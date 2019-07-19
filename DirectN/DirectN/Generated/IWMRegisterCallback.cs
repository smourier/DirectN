// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wmsdkidl.h(9556,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("cf4b1f99-4de2-4e49-a363-252740d99bc1"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMRegisterCallback
    {
        [PreserveSig]
        HRESULT Advise(/* [in] */ IWMStatusCallback pCallback, /* [in] */ IntPtr pvContext);
        
        [PreserveSig]
        HRESULT Unadvise(/* [in] */ IWMStatusCallback pCallback, /* [in] */ IntPtr pvContext);
    }
}
