// c:\program files (x86)\windows kits\10\include\10.0.22621.0\um\d3dhal.h(556,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DHAL_GETSTATEDATA
    {
        public IntPtr dwhContext;
        public uint dwWhich;
        public _D3DSTATE ddState;
        public HRESULT ddrval;
    }
}
