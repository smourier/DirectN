using System;

namespace DirectN
{
    [Flags]
    public enum DecamelizeOptions
    {
        None = 0x0,
        ForceFirstUpper = 0x1,
        ForceRestLower = 0x2,
        UnescapeUnicode = 0x4,
        UnescapeHexadecimal = 0x8,
        ReplaceSpacesByUnderscore = 0x10,
        ReplaceSpacesByMinus = 0x20,
        ReplaceSpacesByDot = 0x40,
        KeepFirstUnderscores = 0x80,
        DontDecamelizeNumbers = 0x100,
        KeepFormattingIndices = 0x200,
        Default = ForceFirstUpper | UnescapeUnicode | UnescapeHexadecimal | KeepFirstUnderscores,
    }
}
