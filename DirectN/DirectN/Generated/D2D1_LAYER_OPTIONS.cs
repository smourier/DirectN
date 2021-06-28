// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1.h(694,9)
using System;

namespace DirectN
{
    /// <summary>
    /// Specified options that can be applied when a layer resource is applied to create a layer.
    /// </summary>
    [Flags]
    public enum D2D1_LAYER_OPTIONS
    {
        D2D1_LAYER_OPTIONS_NONE = 0x00000000,
        
        /// <summary>
        /// The layer will render correctly for ClearType text. If the render target was set to ClearType previously, the layer will continue to render ClearType. If the render target was set to ClearType and this option is not specified, the render target will be set to render gray-scale until the layer is popped. The caller can override this default by calling SetTextAntialiasMode while within the layer. This flag is slightly slower than the default.
        /// </summary>
        D2D1_LAYER_OPTIONS_INITIALIZE_FOR_CLEARTYPE = 0x00000001,
        
        /// <summary>
        /// The layer will render correctly for ClearType text. If the render target was set to ClearType previously, the layer will continue to render ClearType. If the render target was set to ClearType and this option is not specified, the render target will be set to render gray-scale until the layer is popped. The caller can override this default by calling SetTextAntialiasMode while within the layer. This flag is slightly slower than the default.
        /// </summary>
        D2D1_LAYER_OPTIONS_FORCE_DWORD = unchecked((int)0xFFFFFFFF),
    }
}
