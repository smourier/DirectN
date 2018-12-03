// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d9helper.h(152,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("24f416e6-1f67-4aa7-b88e-d33f6f3128a1"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DVolume9
    {
        [PreserveSig]
        HRESULT GetDevice(ref IDirect3DDevice9 ppDevice);
        
        [PreserveSig]
        HRESULT SetPrivateData([MarshalAs(UnmanagedType.LPStruct)] Guid refguid, IntPtr pData, uint SizeOfData, uint Flags);
        
        [PreserveSig]
        HRESULT GetPrivateData([MarshalAs(UnmanagedType.LPStruct)] Guid refguid, [MarshalAs(UnmanagedType.IUnknown)] object pData, ref uint pSizeOfData);
        
        [PreserveSig]
        HRESULT FreePrivateData([MarshalAs(UnmanagedType.LPStruct)] Guid refguid);
        
        [PreserveSig]
        HRESULT GetContainer([MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] object ppContainer);
        
        [PreserveSig]
        HRESULT GetDesc(ref _D3DVOLUME_DESC pDesc);
        
        [PreserveSig]
        HRESULT LockBox(ref _D3DLOCKED_BOX pLockedVolume, ref _D3DBOX pBox, uint Flags);
        
        [PreserveSig]
        HRESULT UnlockBox();
    }
}
