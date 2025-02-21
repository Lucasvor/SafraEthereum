using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafraBC.Model;

public class AccessListItem
{
    public string Address { get; set; }
    public List<byte[]> StorageKeys { get; set; }

    public AccessListItem()
    {
        StorageKeys = new List<byte[]>();
    }

    public AccessListItem(string address, List<byte[]> storageKeys)
    {
        this.Address = address;
        this.StorageKeys = storageKeys;
    }
}