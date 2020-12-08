using System.Drawing;
using System.Windows.Forms;

namespace AirForce_Sound_Supporter
{
    public partial class Form1 : Form
    {
        Point mMyPoint;


        public Form1()
        {
            InitializeComponent();
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mMyPoint.X = e.X;
                mMyPoint.Y = e.Y;
            }
        }

        private void lblTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + (e.X - mMyPoint.X)

                , this.Location.Y + (e.Y - mMyPoint.Y));
            }
        }
    }
}
