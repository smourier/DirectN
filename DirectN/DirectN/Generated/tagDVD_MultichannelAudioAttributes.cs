// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\strmif.h(22271,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagDVD_MultichannelAudioAttributes
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public tagDVD_MUA_MixingInfo[] Info;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public tagDVD_MUA_Coeff[] Coeff;
    }
}
