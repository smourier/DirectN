using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct DXGI_SHARED_RESOURCE
    {
        public IntPtr Handle;
    }
}
