// generated from <Windows SDK Path>\shared\d3d9.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("dd13c59c-36fa-4098-a8fb-c7ed39dc8546"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DVertexDeclaration9
    {
        [PreserveSig]
        HRESULT GetDevice(out IDirect3DDevice9 ppDevice);
        
        [PreserveSig]
        HRESULT GetDeclaration(ref _D3DVERTEXELEMENT9 pElement, ref uint pNumElements);
    }
}
