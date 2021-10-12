// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxva.h(2294,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVA_ProcAmpControlQueryRange
    {
        public uint Size;
        public _DXVA_ProcAmpControlProp ProcAmpControlProp;
        public _DXVA_VideoDesc VideoDesc;
    }
}
