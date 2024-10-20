// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_NOTIFY_WORK_SUBMISSION
    {
        public uint hDoorbell;
        public _D3DKMT_NOTIFY_WORK_SUBMISSION_FLAGS Flags;
    }
}
