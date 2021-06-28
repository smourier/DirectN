// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1.h(1009,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Allows additional parameters for factory creation.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_FACTORY_OPTIONS
    {
        /// <summary>
        /// Requests a certain level of debugging information from the debug layer. This parameter is ignored if the debug layer DLL is not present.
        /// </summary>
        public D2D1_DEBUG_LEVEL debugLevel;
    }
}
