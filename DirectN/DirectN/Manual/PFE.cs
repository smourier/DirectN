using System;

namespace DirectN
{
    [Flags]
#pragma warning disable CA1028 // Enum Storage should be Int32
    public enum PFE : short
#pragma warning restore CA1028 // Enum Storage should be Int32
    {
        PFE_RTLPARA = (PFM.PFM_RTLPARA >> 16),
        PFE_KEEP = (PFM.PFM_KEEP >> 16),
        PFE_KEEPNEXT = (PFM.PFM_KEEPNEXT >> 16),
        PFE_PAGEBREAKBEFORE = (PFM.PFM_PAGEBREAKBEFORE >> 16),
        PFE_NOLINENUMBER = (PFM.PFM_NOLINENUMBER >> 16),
        PFE_NOWIDOWCONTROL = (PFM.PFM_NOWIDOWCONTROL >> 16),
        PFE_DONOTHYPHEN = (PFM.PFM_DONOTHYPHEN >> 16),
        PFE_SIDEBYSIDE = (PFM.PFM_SIDEBYSIDE >> 16),
        PFE_TEXTWRAPPINGBREAK = (PFM.PFM_TEXTWRAPPINGBREAK >> 16),
        PFE_COLLAPSED = (PFM.PFM_COLLAPSED >> 16),
        PFE_BOX = (PFM.PFM_BOX >> 16),
        PFE_TABLE = (PFM.PFM_TABLE >> 16),
        PFE_TABLEROWDELIMITER = (PFM.PFM_TABLEROWDELIMITER >> 16),
    }
}
