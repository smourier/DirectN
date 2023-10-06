using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("603e88e4-a338-4ffe-a457-a5cfb9ceb899"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDispatcherQueue
    {
        // just because InterfaceIsIInspectable doesn't work any more
        void GetIIds();
        void GetRuntimeClassName();
        void GetTrustLevel();

        // undone
    }
}
