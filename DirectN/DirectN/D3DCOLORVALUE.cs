using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using D3DVALUE = System.Single;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct D3DCOLORVALUE
    {
        public D3DVALUE r;
        public D3DVALUE g;
        public D3DVALUE b;
        public D3DVALUE a;
    }
}
