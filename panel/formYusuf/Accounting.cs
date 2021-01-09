using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace panel
{
    class Accounting
    {

        int entryID;

        string entryName;

        string entryMType;

        string entryType;

        int entryAmount;    

        public int EntryID { get => entryID; set => entryID = value; }
        public string EntryName { get => entryName; set => entryName = value; }
        public string EntryMType { get => entryMType; set => entryMType = value; }
        public string EntryType { get => entryType; set => entryType = value; }
        public int EntryAmount { get => entryAmount; set => entryAmount = value; }
    }
}
