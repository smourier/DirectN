// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3d9.h(183,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("dd13c59c-36fa-4098-a8fb-c7ed39dc8546"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DVertexDeclaration9
    {
        [PreserveSig]
        HRESULT GetDevice(IDirect3DDevice9 ppDevice);
        
        [PreserveSig]
        HRESULT GetDeclaration(ref _D3DVERTEXELEMENT9 pElement, ref uint pNumElements);
    }
}
