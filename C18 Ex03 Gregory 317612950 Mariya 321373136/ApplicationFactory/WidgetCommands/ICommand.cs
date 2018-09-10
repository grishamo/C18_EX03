using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C18_Ex03_Gregory_317612950_Mariya_321373136
{
    public interface ICommand
    {
        void Execute();
        void SetParams(params object[] args);
    }
}
