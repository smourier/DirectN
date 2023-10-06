using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("2C9DB356-E70D-4642-8298-BC4AA5B4865C"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ICompositionCapabilitiesInteropFactory
    {
        // just because InterfaceIsIInspectable doesn't work any more
        void GetIIds();
        void GetRuntimeClassName();
        void GetTrustLevel();

        [PreserveSig]
        HRESULT GetForWindow(IntPtr hwnd, [MarshalAs(UnmanagedType.IInspectable)] out object result);
    }
}
