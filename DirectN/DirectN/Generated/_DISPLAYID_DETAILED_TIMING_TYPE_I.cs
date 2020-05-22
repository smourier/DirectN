// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmdt.h(675,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DISPLAYID_DETAILED_TIMING_TYPE_I
    {
        public _DISPLAYID_DETAILED_TIMING_TYPE_I__struct_0 __field_0;
        public ushort HorizontalActivePixels;
        public ushort HorizontalBlankPixels;
        public _DISPLAYID_DETAILED_TIMING_TYPE_I__struct_1 __field_3;
        public ushort HorizontalSyncWidth;
        public ushort VerticalActiveLines;
        public ushort VerticalBlankLines;
        public _DISPLAYID_DETAILED_TIMING_TYPE_I__struct_2 __field_7;
        public ushort VerticalSyncWidth;
    }
}
