// c:\program files (x86)\windows kits\10\include\10.0.22621.0\um\wingdi.h(3342,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _OUTLINETEXTMETRICA
    {
        public uint otmSize;
        public tagTEXTMETRICA otmTextMetrics;
        public byte otmFiller;
        public tagPANOSE otmPanoseNumber;
        public uint otmfsSelection;
        public uint otmfsType;
        public int otmsCharSlopeRise;
        public int otmsCharSlopeRun;
        public int otmItalicAngle;
        public uint otmEMSquare;
        public int otmAscent;
        public int otmDescent;
        public uint otmLineGap;
        public uint otmsCapEmHeight;
        public uint otmsXHeight;
        public tagRECT otmrcFontBox;
        public int otmMacAscent;
        public int otmMacDescent;
        public uint otmMacLineGap;
        public uint otmusMinimumPPEM;
        public tagPOINT otmptSubscriptSize;
        public tagPOINT otmptSubscriptOffset;
        public tagPOINT otmptSuperscriptSize;
        public tagPOINT otmptSuperscriptOffset;
        public uint otmsStrikeoutSize;
        public int otmsStrikeoutPosition;
        public int otmsUnderscoreSize;
        public int otmsUnderscorePosition;
        [MarshalAs(UnmanagedType.LPStr)] 
        public string otmpFamilyName;
        [MarshalAs(UnmanagedType.LPStr)] 
        public string otmpFaceName;
        [MarshalAs(UnmanagedType.LPStr)] 
        public string otmpStyleName;
        [MarshalAs(UnmanagedType.LPStr)] 
        public string otmpFullName;
    }
}
