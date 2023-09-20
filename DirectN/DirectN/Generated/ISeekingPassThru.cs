// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("36b73883-c2c8-11cf-8b46-00805f6cef60"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ISeekingPassThru
    {
        [PreserveSig]
        HRESULT Init(/* [in] */ bool bSupportRendering, /* [in] */ IPin pPin);
    }
}
