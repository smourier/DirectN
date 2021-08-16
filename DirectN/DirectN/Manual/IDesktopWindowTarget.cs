using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("6329D6CA-3366-490E-9DB3-25312929AC51"), InterfaceType(ComInterfaceType.InterfaceIsIInspectable)]
    public interface IDesktopWindowTarget
    {
        [PreserveSig]
        HRESULT get_IsTopmost(out bool value);
    }
}
