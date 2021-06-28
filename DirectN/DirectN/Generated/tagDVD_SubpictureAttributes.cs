// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\strmif.h(21240,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagDVD_SubpictureAttributes
    {
        public tagDVD_SUBPICTURE_TYPE Type;
        public tagDVD_SUBPICTURE_CODING CodingMode;
        public uint Language;
        public tagDVD_SUBPICTURE_LANG_EXT LanguageExtension;
    }
}
