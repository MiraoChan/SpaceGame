using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace PlariumArcade.Model.Entities.BaseEntities
{
    /// <summary>
    /// interface for duty
    ///  be able to display the inherited
    ///  object in the graphical interface
    ///  using a picture
    /// </summary>
     public interface ITileAble{   
        /// <summary>
        /// object picture
        /// </summary>
        Image Tile { get; set; }
    }
}
