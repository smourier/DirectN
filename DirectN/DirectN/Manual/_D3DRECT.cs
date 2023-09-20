// from <Windows SDK Path>\um\d3dtypes.h(188,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DRECT
    {
        public int x1;
        public int y1;
        public int x2;
        public int y2;
    }
}
