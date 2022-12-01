using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogBook.CustomControls;

public class TextEditButton : Button
{
    public bool Checked { get; set; }


    public TextEditButton()
    {
        BackgroundImageLayout = ImageLayout.Zoom;
        FlatAppearance.BorderSize = 0;
        FlatStyle = FlatStyle.Flat;
        Size = new(30, 30);
    }
}
