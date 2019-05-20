// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\ksmedia.h(7276,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSPROPERTY_DROPPEDFRAMES_CURRENT_S
    {
        public KSIDENTIFIER Property;
        public long PictureNumber;
        public long DropCount;
        public uint AverageFrameSize;
    }
}
