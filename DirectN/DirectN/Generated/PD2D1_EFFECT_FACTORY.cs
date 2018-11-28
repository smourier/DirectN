using System.Runtime.InteropServices;

namespace DirectN
{
    public delegate HRESULT PD2D1_EFFECT_FACTORY([MarshalAs(UnmanagedType.IUnknown)] out object effectImpl);
}
