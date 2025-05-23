using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace курсовая
{
    public static class ControlHelper
    // Центрирует элемент управления относительно его родительского контейнера
    {
        public static void CenterControl(Control control)
        {
            if (control != null && control.Parent != null)
            {
                control.Anchor = AnchorStyles.None;
                control.Location = new Point(
                    (control.Parent.ClientSize.Width - control.Width) / 2,
                    (control.Parent.ClientSize.Height - control.Height) / 2
                );
            }
        }
    }
}
