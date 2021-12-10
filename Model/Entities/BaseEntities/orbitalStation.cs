using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlariumArcade.Model.Entities.BaseEntities
{
    class orbitalStation : ITileAble
    {
        public Image Tile { get; set; }
        public orbitalStation() { new NotImplementedException(); }
    }
}
