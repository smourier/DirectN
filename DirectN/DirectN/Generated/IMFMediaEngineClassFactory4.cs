// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfmediaengine.h(8803,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("fbe256c1-43cf-4a9b-8cb8-ce8632a34186"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaEngineClassFactory4
    {
        [PreserveSig]
        HRESULT CreateContentDecryptionModuleFactory(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string keySystem, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation][iid_is][out] _Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvObject);
    }
}
