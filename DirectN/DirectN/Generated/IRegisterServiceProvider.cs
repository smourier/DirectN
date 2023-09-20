// generated from <Windows SDK Path>\um\strmif.h
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
