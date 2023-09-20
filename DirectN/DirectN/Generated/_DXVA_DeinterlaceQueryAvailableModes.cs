// generated from <Windows SDK Path>\um\dxva.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVA_DeinterlaceQueryAvailableModes
    {
        public uint Size;
        public uint NumGuids;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public Guid[] Guids;
    }
}
