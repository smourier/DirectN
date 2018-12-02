// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11_3.h(482,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("0c711683-2853-4846-9bb0-f3e60639e46a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11Texture3D1
    {
        [PreserveSig]
        void GetDesc1(/* [annotation] _Out_ */ out D3D11_TEXTURE3D_DESC1 pDesc);
    }
}
