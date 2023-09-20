// generated from <Windows SDK Path>\um\dxva.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_Deblock_H264
    {
        public ushort CurrMbAddr;
        public _DXVA_Deblock_H264__union_0 __union_1;
        public byte Reserved8Bits;
        public byte bbSinternalLeftVert;
        public byte bbSinternalMidVert;
        public byte bbSinternalRightVert;
        public byte bbSinternalTopHorz;
        public byte bbSinternalMidHorz;
        public byte bbSinternalBotHorz;
        public ushort wbSLeft0;
        public ushort wbSLeft1;
        public ushort wbSTop0;
        public ushort wbSTop1;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)] 
        public _DXVA_DeblockIndexAB_H264[] IndexAB;
    }
}
