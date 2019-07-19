// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d2d1.h(951,9)
namespace DirectN
{
    /// <summary>
    /// Specifies how a device context is initialized for GDI rendering when it is retrieved from the render target.
    /// </summary>
    public enum D2D1_DC_INITIALIZE_MODE
    {
        /// <summary>
        /// The contents of the D2D render target will be copied to the DC.
        /// </summary>
        D2D1_DC_INITIALIZE_MODE_COPY = 0,
        
        /// <summary>
        /// The contents of the DC will be cleared.
        /// </summary>
        D2D1_DC_INITIALIZE_MODE_CLEAR = 1,
        
        /// <summary>
        /// The contents of the DC will be cleared.
        /// </summary>
        D2D1_DC_INITIALIZE_MODE_FORCE_DWORD = -1,
    }
}
