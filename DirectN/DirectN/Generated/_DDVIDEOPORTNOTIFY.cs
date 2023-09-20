// generated from <Windows SDK Path>\um\dvp.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDVIDEOPORTNOTIFY
    {
        public long ApproximateTimeStamp;
        public int lField;
        public uint dwSurfaceIndex;
        public int lDone;
    }
}
