using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace beadando.Abstraction
{
    class ButtonDesign : Button
    {
        public ButtonDesign()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.BackColor = Color.DarkGray;
            this.FlatAppearance.BorderSize = 0;
            this.FlatAppearance.MouseOverBackColor = Color.Silver;
            this.FlatAppearance.MouseDownBackColor = Color.Gray;
        }
    }
}
