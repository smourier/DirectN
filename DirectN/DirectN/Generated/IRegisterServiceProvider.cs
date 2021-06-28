// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\strmif.h(16625,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("7b3a2f01-0751-48dd-b556-004785171c54"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IRegisterServiceProvider
    {
        [PreserveSig]
        HRESULT RegisterService(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidService, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pUnkObject);
    }
}
