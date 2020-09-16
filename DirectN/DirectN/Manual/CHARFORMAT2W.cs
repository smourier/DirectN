using System;
using System.Runtime.InteropServices;
using System.Text;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct CHARFORMAT2W
    {
        public int cbSize;
        public CFM dwMask;
        public CFE dwEffects;
        public int yHeight;
        public int yOffset;
        public int crTextColor;
        public byte bCharSet;
        public byte bPitchAndFamily;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)] // 32 * 2
        public byte[] szFaceName;
        public short wWeight;
        public short sSpacing;
        public int crBackColor;
        public int lcid;
        public int dwCookie;
        public short sStyle;
        public short wKerning;
        public byte bUnderlineType;
        public byte bAnimation;
        public byte bRevAuthor;
        public byte bUnderlineColor;

        public string FaceName
        {
            get
            {
                if (szFaceName == null)
                    return null;

                for (int i = 0; i < szFaceName.Length - 2; i += 2)
                {
                    if (szFaceName[i] == 0 && szFaceName[i + 1] == 0)
                        return Encoding.Unicode.GetString(szFaceName, 0, i);
                }
                return Encoding.Unicode.GetString(szFaceName);
            }
            set
            {
                if (value != null)
                {
                    szFaceName = new byte[64];
                    var bytes = Encoding.Unicode.GetBytes(value);
                    Buffer.BlockCopy(bytes, 0, szFaceName, 0, bytes.Length);
                    return;
                }

                if (szFaceName != null)
                {
                    for (int i = 0; i < szFaceName.Length; i++)
                    {
                        szFaceName[i] = 0;
                    }
                }
            }
        }
    }
}
