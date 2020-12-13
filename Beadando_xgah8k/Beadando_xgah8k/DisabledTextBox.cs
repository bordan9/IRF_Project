using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beadando_xgah8k
{
    class DisabledTextBox : TextBox
    {
        public DisabledTextBox()
        {
            this.Enabled = false;
            this.Width = 120;
        }
    }
}
