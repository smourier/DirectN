using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("29E691FA-4567-4DCA-B319-D0F207EB6807"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ICompositorDesktopInterop
    {
        [PreserveSig]
        HRESULT CreateDesktopWindowTarget(IntPtr hwndTarget, bool isTopmost, out IDesktopWindowTarget result);

        [PreserveSig]
        HRESULT EnsureOnThread(int threadId);
    }
}
