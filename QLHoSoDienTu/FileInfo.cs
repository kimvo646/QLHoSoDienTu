using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHoSoDienTu
{
    internal class FileInfo
    {
        string Name;
        DateTime Date;
        
        public string _Name
        {
            get { return Name; }
            set { Name = value; }
        }
        public DateTime _Date
        {
            get { return Date; }
            set { Date = value; }
        }

        public FileInfo()
        {
            Name = "";
            Date = DateTime.Now;
        }

        public FileInfo(string name, DateTime date)
        {
            Name= name;
            Date = date;
        }
    }
}
