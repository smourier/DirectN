// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\strmif.h(21262,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagDVD_TitleMainAttributes__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] __bits;
        public tagDVD_TITLE_APPMODE AppMode => InteropRuntime.Get<tagDVD_TITLE_APPMODE>(__bits, 0, 32);
        public tagDVD_HMSF_TIMECODE TitleLength => InteropRuntime.Get<tagDVD_HMSF_TIMECODE>(__bits, 0, 32);
    }
}
