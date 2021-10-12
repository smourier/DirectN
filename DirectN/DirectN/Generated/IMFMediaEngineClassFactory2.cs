// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfmediaengine.h(5938,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("09083cef-867f-4bf6-8776-dee3a7b42fca"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaEngineClassFactory2
    {
        [PreserveSig]
        HRESULT CreateMediaKeys2(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.BStr)] string keySystem, /* [annotation] _In_ */ [MarshalAs(UnmanagedType.BStr)] string defaultCdmStorePath, /* [annotation] _In_opt_ */ [MarshalAs(UnmanagedType.BStr)] string inprivateCdmStorePath, /* [annotation] _COM_Outptr_ */ out IMFMediaKeys ppKeys);
    }
}
