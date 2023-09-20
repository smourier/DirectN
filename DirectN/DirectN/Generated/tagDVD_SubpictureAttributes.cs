// generated from <Windows SDK Path>\um\strmif.h
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
