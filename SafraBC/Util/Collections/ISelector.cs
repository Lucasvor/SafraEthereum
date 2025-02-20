using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafraBC.Util.Collections;

public interface ISelector<in T>
    : ICloneable
{
    /// <summary>Match the passed in object, returning true if it would be selected by this selector, false
    /// otherwise.</summary>
    /// <param name="candidate">The object to be matched.</param>
    /// <returns><code>true</code> if the objects is matched by this selector, false otherwise.</returns>
    bool Match(T candidate);
}
