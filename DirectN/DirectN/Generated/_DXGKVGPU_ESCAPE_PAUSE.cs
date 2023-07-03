// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3dukmdt.h(277,9)
using System.Runtime.InteropServices;
using LUID = DirectN._LUID;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKVGPU_ESCAPE_PAUSE
    {
        public _DXGKVGPU_ESCAPE_HEAD Header;
        public LUID DeviceLuid;
        public _DXGKVGPU_ESCAPE_PAUSE__union_0 __union_2;
    }
}
