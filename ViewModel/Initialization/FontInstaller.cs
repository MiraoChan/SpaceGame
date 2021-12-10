using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlariumArcade.ViewModel.Initialization
{
    public class FontInstaller
    {
        public void SetMenuFont(MenuScreen screen) 
        {
            screen.MainLabel.Font = InstallFont(60);
            screen.StartButton.Font = InstallFont(18);
            screen.ExitButton.Font = InstallFont(18);
        }
        public void SetGameScreenFont() {
        
        }
       public Font InstallFont(int size)
        {         
            PrivateFontCollection fontCollection = new PrivateFontCollection();
            fontCollection.AddFontFile("C:/Users/user/Desktop/SpaceGameRep/Content/Fonts/DisposableDroidBB_bld.ttf");
            FontFamily family = fontCollection.Families[0];
            return new Font(family, size);
        }
    }
}
