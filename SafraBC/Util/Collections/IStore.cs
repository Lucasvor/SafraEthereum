using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafraBC.Util.Collections;

public interface IStore<out T>
{
    /// <summary>Enumerate the (possibly empty) collection of objects matched by the given selector.</summary>
    /// <param name="selector">The <see cref="ISelector{T}"/> used to select matching objects.</param>
    /// <returns>An <see cref="IEnumerable{T}"/> of the matching objects.</returns>
    IEnumerable<T> EnumerateMatches(ISelector<T> selector);
}
