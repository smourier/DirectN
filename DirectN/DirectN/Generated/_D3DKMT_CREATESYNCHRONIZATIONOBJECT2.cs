// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_CREATESYNCHRONIZATIONOBJECT2
    {
        public uint hDevice;
        public _D3DDDI_SYNCHRONIZATIONOBJECTINFO2 Info;
        public uint hSyncObject;
    }
}
