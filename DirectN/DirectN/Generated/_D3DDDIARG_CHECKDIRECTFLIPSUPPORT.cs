// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dumddi.h(2079,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIARG_CHECKDIRECTFLIPSUPPORT
    {
        public IntPtr hAppSwapchainResource;
        public IntPtr hDWMSwapchainResource;
        public uint CheckDirectFlipFlags;
        public bool Supported;
    }
}
