// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_SHAREOBJECTWITHHOST
    {
        public uint hDevice;
        public uint hObject;
        public ulong Reserved;
        public ulong hVailProcessNtHandle;
    }
}
