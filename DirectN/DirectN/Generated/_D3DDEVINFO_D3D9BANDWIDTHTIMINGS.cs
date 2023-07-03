// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3d9types.h(1963,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DDEVINFO_D3D9BANDWIDTHTIMINGS
    {
        public float MaxBandwidthUtilized;
        public float FrontEndUploadMemoryUtilizedPercent;
        public float VertexRateUtilizedPercent;
        public float TriangleSetupRateUtilizedPercent;
        public float FillRateUtilizedPercent;
    }
}
