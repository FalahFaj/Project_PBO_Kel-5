using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PBO_Kel_5
{
    public interface ISearchable
    {
        string SearchText { get; }
        event EventHandler SearchClicked;
        void AddEnterKeySupport();
    }
}
