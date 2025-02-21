using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafraBC.RLP;

public class RLPItem : IRLPElement
{
    private readonly byte[] _rlpData;

    public RLPItem(byte[] rlpData)
    {
        this._rlpData = rlpData;
    }

    public byte[] RLPData => GetRLPData();

    private byte[] GetRLPData()
    {
        return _rlpData.Length == 0 ? null : _rlpData;
    }
}
