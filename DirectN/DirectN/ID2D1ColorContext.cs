using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("1c4820bb-5771-4518-a581-2fe4dd0ec657"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ID2D1ColorContext : ID2D1Resource
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(out ID2D1Factory factory);

        // ID2D1ColorContext
        [PreserveSig]
        D2D1_COLOR_SPACE GetColorSpace();

        [PreserveSig]
        int GetProfileSize();

        [PreserveSig]
        HRESULT GetProfile(byte[] profile, int profileSize);
    }
}
