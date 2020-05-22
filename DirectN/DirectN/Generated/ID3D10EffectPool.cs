// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d10effect.h(1360,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("9537ab04-3250-412e-8213-fcd2f8677933"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D10EffectPool
    {
        [PreserveSig]
        ID3D10Effect AsEffect();
    }
}
