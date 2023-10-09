using System.ComponentModel;

namespace DirectN
{
    public sealed class VerticalBlankTickerEventArgs : CancelEventArgs
    {
        internal VerticalBlankTickerEventArgs(long ticks)
        {
            Ticks = ticks;
        }

        public long Ticks { get; }
    }
}
