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
        public void SetGameScreenFont(MainGameScreen screen)
        {
            screen.MoneyStat.Font = InstallFont(18);
            screen.OreStat.Font = InstallFont(18);
            screen.MVtStat.Font = InstallFont(18);
            screen.DamageStat.Font = InstallFont(18);
            screen.StrengthStat.Font = InstallFont(18);
            screen.ExitButton.Font = InstallFont(18);
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
