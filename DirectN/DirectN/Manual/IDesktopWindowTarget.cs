using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("6329D6CA-3366-490E-9DB3-25312929AC51"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDesktopWindowTarget
    {
        // just because InterfaceIsIInspectable doesn't work any more
        void GetIIds();
        void GetRuntimeClassName();
        void GetTrustLevel();

        [PreserveSig]
        HRESULT get_IsTopmost(out bool value);
    }
}
