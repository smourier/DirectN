// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d.h(905,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("4417c145-33ad-11cf-816f-0000c020156e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DExecuteBuffer
    {
        [PreserveSig]
        HRESULT Initialize(IDirect3DDevice __unnamed_0, ref _D3DExecuteBufferDesc __unnamed_1);
        
        [PreserveSig]
        HRESULT Lock(ref _D3DExecuteBufferDesc __unnamed_0);
        
        [PreserveSig]
        HRESULT Unlock();
        
        [PreserveSig]
        HRESULT SetExecuteData(ref _D3DEXECUTEDATA __unnamed_0);
        
        [PreserveSig]
        HRESULT GetExecuteData(ref _D3DEXECUTEDATA __unnamed_0);
        
        [PreserveSig]
        HRESULT Validate(ref uint __unnamed_0, IntPtr __unnamed_1, IntPtr __unnamed_2, uint __unnamed_3);
        
        [PreserveSig]
        HRESULT Optimize(uint __unnamed_0);
    }
}
