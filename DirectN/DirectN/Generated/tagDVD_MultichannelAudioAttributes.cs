// generated from <Windows SDK Path>\um\strmif.h
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
