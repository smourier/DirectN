// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1.h(783,9)
namespace DirectN
{
    /// <summary>
    /// Describes whether a render target uses hardware or software rendering, or if Direct2D should select the rendering mode.
    /// </summary>
    public enum D2D1_RENDER_TARGET_TYPE
    {
        /// <summary>
        /// D2D is free to choose the render target type for the caller.
        /// </summary>
        D2D1_RENDER_TARGET_TYPE_DEFAULT = 0,
        
        /// <summary>
        /// The render target will render using the CPU.
        /// </summary>
        D2D1_RENDER_TARGET_TYPE_SOFTWARE = 1,
        
        /// <summary>
        /// The render target will render using the GPU.
        /// </summary>
        D2D1_RENDER_TARGET_TYPE_HARDWARE = 2,
        
        /// <summary>
        /// The render target will render using the GPU.
        /// </summary>
        D2D1_RENDER_TARGET_TYPE_FORCE_DWORD = -1,
    }
}
