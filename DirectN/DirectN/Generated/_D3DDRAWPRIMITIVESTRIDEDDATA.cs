// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3dtypes.h(2020,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DDRAWPRIMITIVESTRIDEDDATA
    {
        public _D3DDP_PTRSTRIDE position;
        public _D3DDP_PTRSTRIDE normal;
        public _D3DDP_PTRSTRIDE diffuse;
        public _D3DDP_PTRSTRIDE specular;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public _D3DDP_PTRSTRIDE[] textureCoords;
    }
}
