using System.ComponentModel;

namespace DirectN
{
    public sealed class VerticalBlankTickerErrorEventArgs : HandledEventArgs
    {
        internal VerticalBlankTickerErrorEventArgs(long ticks, int error)
        {
            Ticks = ticks;
            Error = error;
        }

        public long Ticks { get; }
        public int Error { get; }
        public bool Stop { get; set; }
    }
}
