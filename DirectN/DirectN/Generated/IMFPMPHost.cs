// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(15137,5)
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace DirectN
{
    [Guid("f70ca1a9-fdc7-4782-b994-adffb1c98606"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFPMPHost
    {
        [PreserveSig]
        HRESULT LockProcess();
        
        [PreserveSig]
        HRESULT UnlockProcess();
        
        [PreserveSig]
        HRESULT CreateObjectByCLSID(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid clsid, /* [unique][in] */ ref IStream pStream, /* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [iid_is][out] */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
    }
}
