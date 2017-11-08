using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtBuddy.Forms.Interfaces
{
    public interface IFileHelper
    {
        string GetLocalFilePath(string filename);
    }
}
