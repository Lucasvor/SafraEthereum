using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafraBC.runtime.intrinsics.x86;

internal static class Sse41
{
#if NETCOREAPP3_0_OR_GREATER
    internal static bool IsEnabled => System.Runtime.Intrinsics.X86.Sse41.IsSupported;
#else
        internal static bool IsEnabled => false;
#endif

    //        internal static class X64
    //        {
    //#if NETCOREAPP3_0_OR_GREATER
    //            internal static bool IsEnabled => System.Runtime.Intrinsics.X86.Sse41.X64.IsSupported;
    //#else
    //            internal static bool IsEnabled => false;
    //#endif
    //        }
}
