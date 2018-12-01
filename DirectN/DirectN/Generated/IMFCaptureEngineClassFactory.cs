// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfcaptureengine.h(1659,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("8f02d140-56fc-4302-a705-3a97c78be779"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFCaptureEngineClassFactory
    {
        [PreserveSig]
        HRESULT CreateInstance(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid clsid, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation][iid_is][out] _Out_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvObject);
    }
}
