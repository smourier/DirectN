using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("22f34e66-50db-4e36-a98d-61c01b384d20"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDispatcherQueueController
    {
        // just because InterfaceIsIInspectable doesn't work any more
        void GetIIds();
        void GetRuntimeClassName();
        void GetTrustLevel();

        [PreserveSig]
        HRESULT get_DispatcherQueue(out IDispatcherQueue value);

        [PreserveSig]
        HRESULT ShutdownQueueAsync(/*Windows.Foundation.IAsyncAction*/ IntPtr operation);
    };
}
