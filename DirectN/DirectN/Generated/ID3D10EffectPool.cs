// generated from <Windows SDK Path>\um\d3d10effect.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("9537ab04-3250-412e-8213-fcd2f8677933"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D10EffectPool
    {
        [PreserveSig]
        ID3D10Effect AsEffect();
    }
}
