using System.Runtime.InteropServices;
using DirectN.Manual;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public class DWM_THUMBNAIL_PROPERTIES
    {
        public DWM_TNP dwFlags;
        public tagRECT rcDestination;
        public tagRECT rcSource;
        public byte opacity;
        public bool fVisible;
        public bool fSourceClientAreaOnly;
    }
}
