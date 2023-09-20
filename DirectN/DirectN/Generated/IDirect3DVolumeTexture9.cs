// generated from <Windows SDK Path>\shared\d3d9.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("2518526c-e789-4111-a7b9-47ef328d13e6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DVolumeTexture9 : IDirect3DBaseTexture9
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
        
        // IDirect3DVolumeTexture9
        [PreserveSig]
        HRESULT GetLevelDesc(uint Level, ref _D3DVOLUME_DESC pDesc);
        
        [PreserveSig]
        HRESULT GetVolumeLevel(uint Level, out IDirect3DVolume9 ppVolumeLevel);
        
        [PreserveSig]
        HRESULT LockBox(uint Level, ref _D3DLOCKED_BOX pLockedVolume, ref _D3DBOX pBox, uint Flags);
        
        [PreserveSig]
        HRESULT UnlockBox(uint Level);
        
        [PreserveSig]
        HRESULT AddDirtyBox(ref _D3DBOX pDirtyBox);
    }
}
