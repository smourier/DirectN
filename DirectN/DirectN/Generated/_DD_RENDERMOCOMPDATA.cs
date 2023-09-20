// generated from <Windows SDK Path>\um\ddrawint.h
using System;
using System.Runtime.InteropServices;
using PDD_DIRECTDRAW_LOCAL = DirectN._DD_DIRECTDRAW_LOCAL;
using PDD_MOTIONCOMP_LOCAL = DirectN._DD_MOTIONCOMP_LOCAL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_RENDERMOCOMPDATA
    {
        public IntPtr lpDD;
        public IntPtr lpMoComp;
        public uint dwNumBuffers;
        public IntPtr lpBufferInfo;
        public uint dwFunction;
        public IntPtr lpInputData;
        public uint dwInputDataSize;
        public IntPtr lpOutputData;
        public uint dwOutputDataSize;
        public HRESULT ddRVal;
    }
}
