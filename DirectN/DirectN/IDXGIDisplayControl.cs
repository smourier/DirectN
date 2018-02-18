using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("ea9dbf1a-c88e-4486-854a-98aa0138f30c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGIDisplayControl
    {
        [PreserveSig]
        bool IsStereoEnabled();
        
        [PreserveSig]
        void SetStereoEnabled(bool enabled);
    }
}
