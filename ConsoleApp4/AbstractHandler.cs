using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
  public abstract  class AbstractHandler
    {
        public abstract void Open();

        public abstract void Create();
        public abstract void Change();
        public abstract void Save();

    }
}
