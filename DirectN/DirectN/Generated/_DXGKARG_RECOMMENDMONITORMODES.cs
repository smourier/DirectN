// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;
using D3DKMDT_HMONITORSOURCEMODESET = DirectN.D3DKMDT_HMONITORSOURCEMODESET__;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_RECOMMENDMONITORMODES
    {
        public uint VideoPresentTargetId;
        public IntPtr hMonitorSourceModeSet;
        public IntPtr pMonitorSourceModeSetInterface;
    }
}
