using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyre_Shop.models.Interfaces
{
    public interface Ilogin
    {
        #region Properties
        string User { get; }
        string Password { get; }
        #endregion

        void NavigateToRegister();


        //void NavigateToMainForm(string username);

    }
}
