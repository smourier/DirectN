// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite_1.h(836,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Script-specific properties for caret navigation and justification.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_SCRIPT_PROPERTIES
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
        public byte[] __bits;
        /// <summary>
        /// The standardized four character code for the given script. Note these only include the general Unicode scripts, not any additional ISO 15924 scripts for bibliographic distinction (for example, Fraktur Latin vs Gaelic Latin). http://unicode.org/iso15924/iso15924-codes.html
        /// </summary>
        public uint isoScriptCode => InteropRuntime.GetUInt32Bits(__bits, 0, 32);
        /// <summary>
        /// The standardized numeric code, ranging 0-999. http://unicode.org/iso15924/iso15924-codes.html
        /// </summary>
        public uint isoScriptNumber => InteropRuntime.GetUInt32Bits(__bits, 32, 32);
        /// <summary>
        /// Number of characters to estimate look-ahead for complex scripts. Latin and all Kana are generally 1. Indic scripts are up to 15, and most others are 8. Note that combining marks and variation selectors can produce clusters longer than these look-aheads, so this estimate is considered typical language use. Diacritics must be tested explicitly separately.
        /// </summary>
        public uint clusterLookahead => InteropRuntime.GetUInt32Bits(__bits, 64, 32);
        /// <summary>
        /// Appropriate character to elongate the given script for justification.
        /// </summary>
        public uint justificationCharacter => InteropRuntime.GetUInt32Bits(__bits, 96, 32);
        /// <summary>
        /// Restrict the caret to whole clusters, like Thai and Devanagari. Scripts such as Arabic by default allow navigation between clusters. Others like Thai always navigate across whole clusters.
        /// </summary>
        public uint restrictCaretToClusters => InteropRuntime.GetUInt32Bits(__bits, 128, 1);
        /// <summary>
        /// The language uses dividers between words, such as spaces between Latin or the Ethiopic wordspace.
        /// </summary>
        public uint usesWordDividers => InteropRuntime.GetUInt32Bits(__bits, 129, 1);
        /// <summary>
        /// The characters are discrete units from each other. This includes both block scripts and clustered scripts.
        /// </summary>
        public uint isDiscreteWriting => InteropRuntime.GetUInt32Bits(__bits, 130, 1);
        /// <summary>
        /// The language is a block script, expanding between characters.
        /// </summary>
        public uint isBlockWriting => InteropRuntime.GetUInt32Bits(__bits, 131, 1);
        /// <summary>
        /// The language is justified within glyph clusters, not just between glyph clusters. One such as the character sequence is Thai Lu and Sara Am (U+E026, U+E033) which form a single cluster but still expand between them.
        /// </summary>
        public uint isDistributedWithinCluster => InteropRuntime.GetUInt32Bits(__bits, 132, 1);
        /// <summary>
        /// The script's clusters are connected to each other (such as the baseline-linked Devanagari), and no separation should be added between characters. Note that cursively linked scripts like Arabic are also connected (but not all connected scripts are cursive).
        /// </summary>
        public uint isConnectedWriting => InteropRuntime.GetUInt32Bits(__bits, 133, 1);
        /// <summary>
        /// The script is naturally cursive (Arabic/Syriac), meaning it uses other justification methods like kashida extension rather than intercharacter spacing. Note that although other scripts like Latin and Japanese may actually support handwritten cursive forms, they are not considered cursive scripts.
        /// </summary>
        public uint isCursiveWriting => InteropRuntime.GetUInt32Bits(__bits, 134, 1);
        public uint reserved => InteropRuntime.GetUInt32Bits(__bits, 135, 25);
    }
}
