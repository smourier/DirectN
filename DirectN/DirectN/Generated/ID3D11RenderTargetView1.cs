// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11_3.h(1470,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("ffbe2e23-f011-418a-ac56-5ceed7c5b94b"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11RenderTargetView1
    {
        [PreserveSig]
        void GetDesc1(/* [annotation] _Out_ */ out D3D11_RENDER_TARGET_VIEW_DESC1 pDesc1);
    }
}
