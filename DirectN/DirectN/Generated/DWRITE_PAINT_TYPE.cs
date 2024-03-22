// generated from <Windows SDK Path>\um\dwrite_3.h
namespace DirectN
{
    /// <summary>
    /// Identifies a type of paint element in a color glyph. A color glyph's visual representation is defined by a tree of paint elements. A paint element's properties are specified by a DWRITE_PAINT_ELEMENT structure, which combines a paint type an a union.  <remarks> For more information about each paint type, see DWRITE_PAINT_ELEMENT. </remarks>
    /// </summary>
    public enum DWRITE_PAINT_TYPE
    {
        DWRITE_PAINT_TYPE_NONE = 0,
        DWRITE_PAINT_TYPE_LAYERS = 1,
        DWRITE_PAINT_TYPE_SOLID_GLYPH = 2,
        DWRITE_PAINT_TYPE_SOLID = 3,
        DWRITE_PAINT_TYPE_LINEAR_GRADIENT = 4,
        DWRITE_PAINT_TYPE_RADIAL_GRADIENT = 5,
        DWRITE_PAINT_TYPE_SWEEP_GRADIENT = 6,
        DWRITE_PAINT_TYPE_GLYPH = 7,
        DWRITE_PAINT_TYPE_COLOR_GLYPH = 8,
        DWRITE_PAINT_TYPE_TRANSFORM = 9,
        DWRITE_PAINT_TYPE_COMPOSITE = 10,
    }
}
