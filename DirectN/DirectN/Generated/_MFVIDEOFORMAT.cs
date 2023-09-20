// generated from <Windows SDK Path>\um\mfobjects.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _MFVIDEOFORMAT
    {
        public uint dwSize;
        public _MFVideoInfo videoInfo;
        public Guid guidFormat;
        public _MFVideoCompressedInfo compressedInfo;
        public _MFVideoSurfaceInfo surfaceInfo;
    }
}
