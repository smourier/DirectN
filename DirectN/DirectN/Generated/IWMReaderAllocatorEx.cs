// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wmsdkidl.h(13103,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("9f762fa7-a22e-428d-93c9-ac82f3aafe5a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMReaderAllocatorEx
    {
        [PreserveSig]
        HRESULT AllocateForStreamEx(/* [in] */ ushort wStreamNum, /* [in] */ uint cbBuffer, /* [out] */ out INSSBuffer ppBuffer, /* [in] */ uint dwFlags, /* [in] */ ulong cnsSampleTime, /* [in] */ ulong cnsSampleDuration, /* [in] */ IntPtr pvContext);
        
        [PreserveSig]
        HRESULT AllocateForOutputEx(/* [in] */ uint dwOutputNum, /* [in] */ uint cbBuffer, /* [out] */ out INSSBuffer ppBuffer, /* [in] */ uint dwFlags, /* [in] */ ulong cnsSampleTime, /* [in] */ ulong cnsSampleDuration, /* [in] */ IntPtr pvContext);
    }
}
