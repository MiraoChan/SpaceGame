using System.Drawing;

namespace PlariumArcade.ViewModel.GraphicControllers
{
    public interface IDraw {
        void DrawObject(MainGameScreen screen, Image image, Point p);
    }
}
