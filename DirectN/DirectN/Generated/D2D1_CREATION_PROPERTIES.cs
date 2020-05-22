// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1_1.h(633,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// This specifies the options while simultaneously creating the device, factory, and device context.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_CREATION_PROPERTIES
    {
        /// <summary>
        /// Describes locking behavior of D2D resources
        /// </summary>
        public D2D1_THREADING_MODE threadingMode;
        public D2D1_DEBUG_LEVEL debugLevel;
        public D2D1_DEVICE_CONTEXT_OPTIONS options;
    }
}
