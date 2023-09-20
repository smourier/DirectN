// generated from <Windows SDK Path>\um\dxva.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_Highlight
    {
        public ushort wHighlightActive;
        public ushort wHighlightIndices;
        public ushort wHighlightAlphas;
        public tagRECT HighlightRect;
    }
}
