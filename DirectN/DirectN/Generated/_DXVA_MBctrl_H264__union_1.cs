// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxva.h(849,3)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_MBctrl_H264__union_1
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public byte[] __bits;
        public _DXVA_MBctrl_H264__union_1__struct_0 __field_0 => InteropRuntime.GetBits<_DXVA_MBctrl_H264__union_1__struct_0>(__bits, 0, 96);
        public _DXVA_MBctrl_H264__union_1__struct_1 __field_1 => InteropRuntime.GetBits<_DXVA_MBctrl_H264__union_1__struct_1>(__bits, 0, 96);
    }
}
