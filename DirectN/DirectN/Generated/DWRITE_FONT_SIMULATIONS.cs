// generated from <Windows SDK Path>\um\dwrite.h
namespace DirectN
{
    /// <summary>
    /// Specifies algorithmic style simulations to be applied to the font face. Bold and oblique simulations can be combined via bitwise OR operation.
    /// </summary>
    public enum DWRITE_FONT_SIMULATIONS
    {
        /// <summary>
        /// No simulations are performed.
        /// </summary>
        DWRITE_FONT_SIMULATIONS_NONE = 0,
        
        /// <summary>
        /// Algorithmic emboldening is performed.
        /// </summary>
        DWRITE_FONT_SIMULATIONS_BOLD = 1,
        
        /// <summary>
        /// Algorithmic italicization is performed.
        /// </summary>
        DWRITE_FONT_SIMULATIONS_OBLIQUE = 2,
    }
}
