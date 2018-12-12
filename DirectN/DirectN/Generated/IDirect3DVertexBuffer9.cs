// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3d9.h(191,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("b64bb1b5-fd70-4df6-bf91-19d0a12455e3"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DVertexBuffer9 : IDirect3DResource9
    {
        // IDirect3DResource9
        [PreserveSig]
        new HRESULT GetDevice(out IDirect3DDevice9 ppDevice);
        
        [PreserveSig]
        new HRESULT SetPrivateData([MarshalAs(UnmanagedType.LPStruct)] Guid refguid, IntPtr pData, uint SizeOfData, uint Flags);
        
        [PreserveSig]
        new HRESULT GetPrivateData([MarshalAs(UnmanagedType.LPStruct)] Guid refguid, [MarshalAs(UnmanagedType.IUnknown)] object pData, ref uint pSizeOfData);
        
        [PreserveSig]
        new HRESULT FreePrivateData([MarshalAs(UnmanagedType.LPStruct)] Guid refguid);
        
        [PreserveSig]
        new uint SetPriority(uint PriorityNew);
        
        [PreserveSig]
        new uint GetPriority();
        
        [PreserveSig]
        new void PreLoad();
        
        [PreserveSig]
        new _D3DRESOURCETYPE GetType();
        
        // IDirect3DVertexBuffer9
        [PreserveSig]
        HRESULT Lock(uint OffsetToLock, uint SizeToLock, [MarshalAs(UnmanagedType.IUnknown)] object ppbData, uint Flags);
        
        [PreserveSig]
        HRESULT Unlock();
        
        [PreserveSig]
        HRESULT GetDesc(ref _D3DVERTEXBUFFER_DESC pDesc);
    }
}
