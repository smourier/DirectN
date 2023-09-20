// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDICB_SUBMITCOMMAND
    {
        public ulong Commands;
        public uint CommandLength;
        public _D3DDDICB_SUBMITCOMMANDFLAGS Flags;
        public uint BroadcastContextCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)] 
        public IntPtr[] BroadcastContext;
        public IntPtr pPrivateDriverData;
        public uint PrivateDriverDataSize;
        public uint NumPrimaries;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] 
        public uint[] WrittenPrimaries;
        public D3DDDI_MARKERLOGTYPE MarkerLogType;
        public uint RenderCBSequence;
        public _D3DDDICB_SUBMITCOMMAND__union_0 __union_11;
        public _D3DDDICB_SUBMITCOMMAND__union_1 __union_12;
        public uint Reserved;
        public uint NumHistoryBuffers;
        public IntPtr HistoryBufferArray;
        public IntPtr pReserved;
    }
}
