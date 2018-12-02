// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11_1.h(435,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("1217d7a6-5039-418c-b042-9cbe256afd6e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11RasterizerState1
    {
        [PreserveSig]
        void GetDesc1(/* [annotation] _Out_ */ out D3D11_RASTERIZER_DESC1 pDesc);
    }
}
