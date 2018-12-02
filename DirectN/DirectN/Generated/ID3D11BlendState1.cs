// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11_1.h(226,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("cc86fabe-da55-401d-85e7-e3c9de2877e9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11BlendState1
    {
        [PreserveSig]
        void GetDesc1(/* [annotation] _Out_ */ out D3D11_BLEND_DESC1 pDesc);
    }
}
