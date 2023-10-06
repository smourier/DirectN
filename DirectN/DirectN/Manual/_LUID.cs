using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct _LUID
    {
        public uint LowPart;
        public int HighPart;

        public long Value => (long)(((ulong)HighPart) << 32 | LowPart);
        public override string ToString() => Value.ToString();
    }
}
