// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxva.h(664,9)
using System;
using System.Runtime.InteropServices;
using RECT = DirectN.tagRECT;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_Highlight
    {
        public ushort wHighlightActive;
        public ushort wHighlightIndices;
        public ushort wHighlightAlphas;
        public RECT HighlightRect;
    }
}
