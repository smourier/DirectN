using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace DirectN
{
    public interface ILogger
    {
        void Log(TraceLevel level, string message = null, [CallerMemberName] string methodName = null);
    }
}
