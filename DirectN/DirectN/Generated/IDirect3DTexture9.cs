// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d9helper.h(144,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("85c31227-3de5-4f00-9b3a-f11ac38c18b5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DTexture9 : IDirect3DBaseTexture9
    {
        // IDirect3DResource9
        [PreserveSig]
        new HRESULT GetDevice(ref IDirect3DDevice9 ppDevice);
        
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
        
        // IDirect3DBaseTexture9
        [PreserveSig]
        new uint SetLOD(uint LODNew);
        
        [PreserveSig]
        new uint GetLOD();
        
        [PreserveSig]
        new uint GetLevelCount();
        
        [PreserveSig]
        new HRESULT SetAutoGenFilterType(_D3DTEXTUREFILTERTYPE FilterType);
        
        [PreserveSig]
        new _D3DTEXTUREFILTERTYPE GetAutoGenFilterType();
        
        [PreserveSig]
        new void GenerateMipSubLevels();
        
        // IDirect3DTexture9
        [PreserveSig]
        HRESULT GetLevelDesc(uint Level, ref _D3DSURFACE_DESC pDesc);
        
        [PreserveSig]
        HRESULT GetSurfaceLevel(uint Level, ref IDirect3DSurface9 ppSurfaceLevel);
        
        [PreserveSig]
        HRESULT LockRect(uint Level, ref _D3DLOCKED_RECT pLockedRect, ref tagRECT pRect, uint Flags);
        
        [PreserveSig]
        HRESULT UnlockRect(uint Level);
        
        [PreserveSig]
        HRESULT AddDirtyRect(ref tagRECT pDirtyRect);
    }
}
