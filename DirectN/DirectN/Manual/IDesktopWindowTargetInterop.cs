using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("35DBF59E-E3F9-45B0-81E7-FE75F4145DC9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDesktopWindowTargetInterop
    {
        [PreserveSig]
        HRESULT get_Hwnd(out IntPtr value);
    }
}
