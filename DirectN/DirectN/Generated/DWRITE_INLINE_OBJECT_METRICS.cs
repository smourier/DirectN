using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct DWRITE_INLINE_OBJECT_METRICS
    {
        public float width;
        public float height;
        public float baseline;
        public bool supportsSideways;
    }
}
