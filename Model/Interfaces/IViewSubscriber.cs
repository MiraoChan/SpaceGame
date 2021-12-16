using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlariumArcade.Model.Interfaces
{
    /// <summary>
    /// An interface for implementing the observer pattern. 
    /// Used to notify the ship about updating the values ​​of the GUI elements
    /// </summary>
    public interface IViewSubscriber
    {
        /// <summary>
        /// Method of duty of renewal
        /// </summary>
        void RenewInfo();
    }
}
