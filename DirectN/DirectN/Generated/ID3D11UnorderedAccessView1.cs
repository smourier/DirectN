// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11_3.h(1805,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("7b3b6153-a886-4544-ab37-6537c8500403"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11UnorderedAccessView1
    {
        [PreserveSig]
        void GetDesc1(/* [annotation] _Out_ */ out D3D11_UNORDERED_ACCESS_VIEW_DESC1 pDesc1);
    }
}
