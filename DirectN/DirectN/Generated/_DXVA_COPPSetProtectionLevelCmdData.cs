// generated from <Windows SDK Path>\um\dxva.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVA_COPPSetProtectionLevelCmdData
    {
        public uint ProtType;
        public uint ProtLevel;
        public uint ExtendedInfoChangeMask;
        public uint ExtendedInfoData;
    }
}
