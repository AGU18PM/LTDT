using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace LTDT
{
    public partial class Node : UserControl
    {
        public Node(int i)
        {
            InitializeComponent();
            GraphicsPath path = new GraphicsPath();
            Rectangle rc = new Rectangle(this.Location, this.Size);
            path.AddArc(rc, 0, 360);
            name.Text = (i + 1).ToString();
            this.Region = new Region(path);
        }
    }
}
