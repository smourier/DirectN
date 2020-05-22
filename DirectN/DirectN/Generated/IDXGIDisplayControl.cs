// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\dxgi1_2.h(135,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("ea9dbf1a-c88e-4486-854a-98aa0138f30c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDXGIDisplayControl
    {
        [PreserveSig]
        bool IsStereoEnabled();
        
        [PreserveSig]
        void SetStereoEnabled(bool enabled);
    }
}
