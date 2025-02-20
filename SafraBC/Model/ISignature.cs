using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafraBC.Model;

public interface ISignature
{
    byte[] R { get; }
    byte[] S { get; }
    byte[] V { get; set; }
}
