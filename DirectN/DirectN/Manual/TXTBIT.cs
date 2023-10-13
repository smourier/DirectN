using System;

namespace DirectN
{
    [Flags]
    public enum TXTBIT
    {
        TXTBIT_RICHTEXT = 1,        // rich-text control
        TXTBIT_MULTILINE = 2,       // single vs multi-line control
        TXTBIT_READONLY = 4,        // read only text
        TXTBIT_SHOWACCELERATOR = 8,     // underline accelerator character
        TXTBIT_USEPASSWORD = 0x10,  // use password char to display text
        TXTBIT_HIDESELECTION = 0x20,    // show selection when inactive
        TXTBIT_SAVESELECTION = 0x40,    // remember selection when inactive
        TXTBIT_AUTOWORDSEL = 0x80,  // auto-word selection 
        TXTBIT_VERTICAL = 0x100,    // vertical 
        TXTBIT_SELBARCHANGE = 0x200,    // notification that the selection bar width has changed. FUTURE: move this bit to the end to maintain the division between  properties and notifications.
        TXTBIT_WORDWRAP = 0x400,// if set, then multi-line controls should wrap words to fit the available display
        TXTBIT_ALLOWBEEP = 0x800,   // enable/disable beeping
        TXTBIT_DISABLEDRAG = 0x1000,  // disable/enable dragging
        TXTBIT_VIEWINSETCHANGE = 0x2000,    // the inset cchanged
        TXTBIT_BACKSTYLECHANGE = 0x4000,
        TXTBIT_MAXLENGTHCHANGE = 0x8000,
        TXTBIT_SCROLLBARCHANGE = 0x10000,
        TXTBIT_CHARFORMATCHANGE = 0x20000,
        TXTBIT_PARAFORMATCHANGE = 0x40000,
        TXTBIT_EXTENTCHANGE = 0x80000,
        TXTBIT_CLIENTRECTCHANGE = 0x100000, // the client rectangle changed
        TXTBIT_USECURRENTBKG = 0x200000,    // tells the renderer to use the current background color rather than the system default for an entire line
        TXTBIT_NOTHREADREFCOUNT = 0x400000, // don't reference TLS data on behalf of this instance
        TXTBIT_SHOWPASSWORD = 0x800000, // Show password string
        TXTBIT_D2DDWRITE = 0x1000000,   // Use D2D/DWrite for this instance (and not GDI/Uniscribe).
        TXTBIT_D2DSIMPLETYPOGRAPHY = 0x2000000, // Don't glyph all. Only valid if D2DDWRITE is set.
        TXTBIT_D2DPIXELSNAPPED = 0x4000000, // Don't do subpixel. Only valid if D2DDWRITE is set.
        TXTBIT_D2DSUBPIXELLINES = 0x8000000,    // Don't pixel-snap text lines and underline, strikethrough in the secondary text flow direction (usually vertical) Only valid if D2DDWRITE is set and D2DPIXELSNAPPED is not set.
        TXTBIT_FLASHLASTPASSWORDCHAR = 0x10000000,  // Show last password char momentarily
        TXTBIT_ADVANCEDINPUT = 0x20000000,	// Use advanced input features.

        TXTBIT_UNDOCUMENTED1 = 0x40000000,
        TXTBIT_UNDOCUMENTED2 = unchecked((int)0x80000000),
    }
}
