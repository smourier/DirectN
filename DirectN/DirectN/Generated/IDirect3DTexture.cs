﻿// generated from <Windows SDK Path>\um\d3d.h
using System;
using System.Runtime.InteropServices;
using LPDIRECT3DTEXTURE = DirectN.IDirect3DTexture;
using LPDIRECTDRAWSURFACE = DirectN.IDirectDrawSurface;

namespace DirectN
{
    [ComImport, Guid("2cdcd9e0-25a0-11cf-a31a-00aa00b93356"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DTexture
    {
        [PreserveSig]
        HRESULT Initialize(IDirect3DDevice unnamed__0, LPDIRECTDRAWSURFACE unnamed__1);
        
        [PreserveSig]
        HRESULT GetHandle(IDirect3DDevice unnamed__0, ref uint unnamed__1);
        
        [PreserveSig]
        HRESULT PaletteChanged(uint unnamed__0, uint unnamed__1);
        
        [PreserveSig]
        HRESULT Load(LPDIRECT3DTEXTURE unnamed__0);
        
        [PreserveSig]
        HRESULT Unload();
    }
}
