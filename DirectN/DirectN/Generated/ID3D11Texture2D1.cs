// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11_3.h(252,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("51218251-1e33-4617-9ccb-4d3a4367e7bb"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11Texture2D1
    {
        [PreserveSig]
        void GetDesc1(/* [annotation] _Out_ */ out D3D11_TEXTURE2D_DESC1 pDesc);
    }
}
