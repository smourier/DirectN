// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite_1.h(516,1)
namespace DirectN
{
    /// <summary>
    /// Specifies the policy used by GetRecommendedRenderingMode to determine whether to render glyphs in outline mode. Glyphs are rendered in outline mode by default at large sizes for performance reasons, but how large (i.e., the outline threshold) depends on the quality of outline rendering. If the graphics system renders anti- aliased outlines then a relatively low threshold is used, but if the graphics system renders aliased outlines then a much higher threshold is used.
    /// </summary>
    public enum DWRITE_OUTLINE_THRESHOLD
    {
        DWRITE_OUTLINE_THRESHOLD_ANTIALIASED = 0,
        DWRITE_OUTLINE_THRESHOLD_ALIASED = 1,
    }
}
