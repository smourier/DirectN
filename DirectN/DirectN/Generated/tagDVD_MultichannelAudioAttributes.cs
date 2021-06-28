// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\strmif.h(21151,9)
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
