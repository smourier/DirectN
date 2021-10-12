// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfapi.h(1648,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagFaceCharacterization
    {
        public uint BlinkScoreLeft;
        public uint BlinkScoreRight;
        public uint FacialExpression;
        public uint FacialExpressionScore;
    }
}
