using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct PARAFORMAT2
    {
        public int cbSize;
        public PFM dwMask;
        public short wNumbering;
        public PFE wEffects;
        public int dxStartIndent;
        public int dxRightIndent;
        public int dxOffset;
        public PFA wAlignment;
        public short cTabCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public int[] rgxTabs;
        public int dySpaceBefore;
        public int dySpaceAfter;
        public int dyLineSpacing;
        public short sStyle;
        public byte bLineSpacingRule;
        public byte bOutlineLevel;
        public short wShadingWeight;
        public short wShadingStyle;
        public short wNumberingStart;
        public short wNumberingStyle;
        public short wNumberingTab;
        public short wBorderSpace;
        public short wBorderWidth;
        public short wBorders;
    }
}
