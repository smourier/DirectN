// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dxdiag.h(106,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("9c6b4cb0-23f8-49cc-a3ed-45a55000a6d2"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDxDiagProvider
    {
        [PreserveSig]
        HRESULT Initialize(ref _DXDIAG_INIT_PARAMS pParams);
        
        [PreserveSig]
        HRESULT GetRootContainer(out IDxDiagContainer ppInstance);
    }
}
