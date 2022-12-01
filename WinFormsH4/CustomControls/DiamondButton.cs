using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogBook.Properties;

namespace LogBook.CustomControls;

public class DiamondButton : Button
{
    public byte Position { get; set; }

    private bool _checked;

    public bool Checked
    {
        get { return _checked; }
        set
        {
            _checked = value;
            BackgroundImage = _checked ? Resources.diamond_fill : Resources.diamond_empty;
        }
    }


    public DiamondButton()
    {
        BackgroundImage = Resources.diamond_empty;
        BackgroundImageLayout = ImageLayout.Zoom;
        FlatAppearance.BorderSize = 0;
        FlatStyle = FlatStyle.Flat;
        Size = new(30,30);
    }
}
