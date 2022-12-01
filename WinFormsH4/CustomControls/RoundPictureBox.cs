using System.Drawing.Drawing2D;

namespace LogBook.Properties;

class RoundPictureBox : PictureBox
{
    public RoundPictureBox() => BackColor = Color.DarkGray;

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        using var gp = new GraphicsPath();
        gp.AddEllipse(new Rectangle(0, 0, Width - 1, Height - 1));
        Region = new Region(gp);
    }
}