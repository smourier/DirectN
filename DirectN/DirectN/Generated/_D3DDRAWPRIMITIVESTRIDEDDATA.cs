// generated from <Windows SDK Path>\um\d3dtypes.h
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
