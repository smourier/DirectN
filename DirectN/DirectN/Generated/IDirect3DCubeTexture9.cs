// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3d9.h(189,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("fff32f81-d953-473a-9223-93d652aba93f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DCubeTexture9 : IDirect3DBaseTexture9
    {
        // IDirect3DResource9
        [PreserveSig]
        new HRESULT GetDevice(out IDirect3DDevice9 ppDevice);
        
        [PreserveSig]
        new HRESULT SetPrivateData([MarshalAs(UnmanagedType.LPStruct)] Guid refguid, IntPtr pData, uint SizeOfData, uint Flags);
        
        [PreserveSig]
        new HRESULT GetPrivateData([MarshalAs(UnmanagedType.LPStruct)] Guid refguid, IntPtr pData, ref uint pSizeOfData);
        
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
        
        // IDirect3DCubeTexture9
        [PreserveSig]
        HRESULT GetLevelDesc(uint Level, ref _D3DSURFACE_DESC pDesc);
        
        [PreserveSig]
        HRESULT GetCubeMapSurface(_D3DCUBEMAP_FACES FaceType, uint Level, out IDirect3DSurface9 ppCubeMapSurface);
        
        [PreserveSig]
        HRESULT LockRect(_D3DCUBEMAP_FACES FaceType, uint Level, ref _D3DLOCKED_RECT pLockedRect, ref tagRECT pRect, uint Flags);
        
        [PreserveSig]
        HRESULT UnlockRect(_D3DCUBEMAP_FACES FaceType, uint Level);
        
        [PreserveSig]
        HRESULT AddDirtyRect(_D3DCUBEMAP_FACES FaceType, ref tagRECT pDirtyRect);
    }
}
