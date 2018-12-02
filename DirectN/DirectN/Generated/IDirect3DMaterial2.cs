// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d.h(1035,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("93281503-8cf8-11d0-89ab-00a0c9054129"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DMaterial2
    {
        [PreserveSig]
        HRESULT SetMaterial(ref _D3DMATERIAL __unnamed_0);
        
        [PreserveSig]
        HRESULT GetMaterial(ref _D3DMATERIAL __unnamed_0);
        
        [PreserveSig]
        HRESULT GetHandle(ref IDirect3DDevice2 __unnamed_0, ref uint __unnamed_1);
    }
}
