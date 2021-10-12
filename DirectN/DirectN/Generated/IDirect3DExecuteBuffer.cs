// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d.h(905,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("4417c145-33ad-11cf-816f-0000c020156e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DExecuteBuffer
    {
        [PreserveSig]
        HRESULT Initialize(IDirect3DDevice unnamed__0, ref _D3DExecuteBufferDesc unnamed__1);
        
        [PreserveSig]
        HRESULT Lock(ref _D3DExecuteBufferDesc unnamed__0);
        
        [PreserveSig]
        HRESULT Unlock();
        
        [PreserveSig]
        HRESULT SetExecuteData(ref _D3DEXECUTEDATA unnamed__0);
        
        [PreserveSig]
        HRESULT GetExecuteData(ref _D3DEXECUTEDATA unnamed__0);
        
        [PreserveSig]
        HRESULT Validate(ref uint unnamed__0, IntPtr unnamed__1, IntPtr unnamed__2, uint unnamed__3);
        
        [PreserveSig]
        HRESULT Optimize(uint unnamed__0);
    }
}
