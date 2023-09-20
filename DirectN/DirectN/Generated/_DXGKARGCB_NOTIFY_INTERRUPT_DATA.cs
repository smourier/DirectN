// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARGCB_NOTIFY_INTERRUPT_DATA
    {
        public _DXGK_INTERRUPT_TYPE InterruptType;
        public _DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0 __union_1;
        public _DXGKCB_NOTIFY_INTERRUPT_DATA_FLAGS Flags;
    }
}
