// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfsharingengine.h(925,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("1fc55727-a7fb-4fc8-83ae-8af024990af1"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFImageSharingEngineClassFactory
    {
        [PreserveSig]
        HRESULT CreateInstanceFromUDN(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.BStr)] string pUniqueDeviceName, /* [annotation][out] _Outptr_ */ out IMFImageSharingEngine ppEngine);
    }
}
