// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_GPUP_PREPARE_LIVE_MIGRATION
    {
        public uint vfIndex;
        public _DXGK_GPUP_MIGRATIONTYPE MigrationType;
    }
}
