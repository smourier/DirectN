// generated from <Windows SDK Path>\shared\dxgi1_2.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("ea9dbf1a-c88e-4486-854a-98aa0138f30c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDXGIDisplayControl
    {
        [PreserveSig]
        bool IsStereoEnabled();
        
        [PreserveSig]
        void SetStereoEnabled(bool enabled);
    }
}
