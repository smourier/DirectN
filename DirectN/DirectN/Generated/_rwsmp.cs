// generated from <Windows SDK Path>\shared\dls1.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _rwsmp
    {
        public uint cbSize;
        public ushort usUnityNote;
        public short sFineTune;
        public int lAttenuation;
        public uint fulOptions;
        public uint cSampleLoops;
    }
}
