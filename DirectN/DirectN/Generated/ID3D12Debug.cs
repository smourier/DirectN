// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12sdklayers.h(199,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("344488b7-6846-474b-b989-f027448245e0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12Debug
    {
        [PreserveSig]
        void EnableDebugLayer();
    }
}
