// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11_3.h(1985,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("631b4766-36dc-461d-8db6-c47e13e60916"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11Query1
    {
        [PreserveSig]
        void GetDesc1(/* [annotation] _Out_ */ out D3D11_QUERY_DESC1 pDesc1);
    }
}
