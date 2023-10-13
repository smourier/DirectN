using System;

namespace DirectN
{
    [Flags]
    public enum TXTNATURALSIZE
    {
        TXTNS_FITTOCONTENT2 = 0, //@emem Get size that fits indented content
        TXTNS_FITTOCONTENT = 1, //@emem Get size that fits content
        TXTNS_ROUNDTOLINE = 2, //@emem Round to nearest whole line
        TXTNS_FITTOCONTENT3 = 3, //@emem Get size that fits indented content + trailing whitespace
        TXTNS_FITTOCONTENTWSP = 4, //@emem Get size that fits unindented content + trailing whitespace
        TXTNS_INCLUDELASTLINE = 0x40000000, //@emem In plain-text ctrl, inc height of a final CR
        TXTNS_EMU = unchecked((int)0x80000000), //@emem EMUs, not pixels are used as measurement units (both ways)
    };
}
