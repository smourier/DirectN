// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1_1.h(570,9)
namespace DirectN
{
    /// <summary>
    /// Defines when font resources should be subset during printing.
    /// </summary>
    public enum D2D1_PRINT_FONT_SUBSET_MODE
    {
        /// <summary>
        /// Subset for used glyphs, send and discard font resource after every five pages
        /// </summary>
        D2D1_PRINT_FONT_SUBSET_MODE_DEFAULT = 0,
        
        /// <summary>
        /// Subset for used glyphs, send and discard font resource after each page
        /// </summary>
        D2D1_PRINT_FONT_SUBSET_MODE_EACHPAGE = 1,
        
        /// <summary>
        /// Do not subset, reuse font for all pages, send it after first page
        /// </summary>
        D2D1_PRINT_FONT_SUBSET_MODE_NONE = 2,
        
        /// <summary>
        /// Do not subset, reuse font for all pages, send it after first page
        /// </summary>
        D2D1_PRINT_FONT_SUBSET_MODE_FORCE_DWORD = -1,
    }
}
