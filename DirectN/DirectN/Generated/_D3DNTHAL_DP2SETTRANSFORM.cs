// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3dnthal.h(831,9)
using System.Runtime.InteropServices;
using D3DMATRIX = DirectN._D3DMATRIX;
using D3DTRANSFORMSTATETYPE = DirectN._D3DTRANSFORMSTATETYPE;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DNTHAL_DP2SETTRANSFORM
    {
        public D3DTRANSFORMSTATETYPE xfrmType;
        public D3DMATRIX matrix;
    }
}
