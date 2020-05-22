// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d12sdklayers.h(169,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("344488b7-6846-474b-b989-f027448245e0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12Debug
    {
        [PreserveSig]
        void EnableDebugLayer();
    }
}
