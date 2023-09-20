// generated from <Windows SDK Path>\um\mfsharingengine.h
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
