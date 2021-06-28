// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\strmif.h(21262,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagDVD_TitleMainAttributes__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public tagDVD_TITLE_APPMODE AppMode { get => InteropRuntime.Get<tagDVD_TITLE_APPMODE>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<tagDVD_TITLE_APPMODE>(value, __bits, 0, 32); } }
        public tagDVD_HMSF_TIMECODE TitleLength { get => InteropRuntime.Get<tagDVD_HMSF_TIMECODE>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<tagDVD_HMSF_TIMECODE>(value, __bits, 0, 32); } }
    }
}
