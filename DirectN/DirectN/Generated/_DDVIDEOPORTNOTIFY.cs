// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dvp.h(403,9)
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
