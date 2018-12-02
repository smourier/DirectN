// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11_3.h(1123,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("91308b87-9040-411d-8c67-c39253ce3802"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11ShaderResourceView1
    {
        [PreserveSig]
        void GetDesc1(/* [annotation] _Out_ */ out D3D11_SHADER_RESOURCE_VIEW_DESC1 pDesc1);
    }
}
