using System.Drawing;


namespace CleanCode.Names
{
    /*
    public class Names
    {
        public Bitmap Method1(string n)
        {
            var b = new Bitmap(n);
            var g = Graphics.FromImage(b);
            g.DrawString("a", SystemFonts.DefaultFont, SystemBrushes.Desktop, new PointF(0, 0));
            g.DrawString("b", SystemFonts.DefaultFont, SystemBrushes.Desktop, new PointF(0, 20));
            g.DrawString("c", SystemFonts.DefaultFont, SystemBrushes.Desktop, new PointF(0, 30));
            return b;
        }
    }
    */
    //correto
    public class Names
    {
        public Bitmap GenerateImage(string path)
        {
            var bitmap = new Bitmap(path);
            var graphics = Graphics.FromImage(bitmap);
            graphics.DrawString("a", SystemFonts.DefaultFont, SystemBrushes.Desktop, new PointF(0, 0));
            graphics.DrawString("b", SystemFonts.DefaultFont, SystemBrushes.Desktop, new PointF(0, 20));
            graphics.DrawString("c", SystemFonts.DefaultFont, SystemBrushes.Desktop, new PointF(0, 30));
            return bitmap;
        }
    }
}