using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamePx
{
    public partial class Space : Form
    {
        static bool game;
        public Space()
        {
            InitializeComponent();
            game = true;
        }

        private void Move(object sender, KeyEventArgs e)
        {
            if (game == true)
            {
                int x, y;
                x = labelHead.Location.X;
                y = labelHead.Location.Y;
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        if (y < 0)
                            y = this.Size.Height;
                        y -= 5;
                        labelHead.Location = new System.Drawing.Point(x, y);
                        break;
                    case Keys.Down:
                        if (y > this.Size.Height)
                            y = 0;
                        y += 5;
                        labelHead.Location = new System.Drawing.Point(x, y);
                        break;
                    case Keys.Left:
                        if (x < 0)
                            x = this.Size.Width;
                        x -= 5;
                        labelHead.Location = new System.Drawing.Point(x, y);
                        break;
                    case Keys.Right:
                        if (this.Size.Width < x)
                            x = 0;
                        x += 5;
                        labelHead.Location = new System.Drawing.Point(x, y);
                        break;
                }
                int tmpCoverX = labelHead.Location.X - labelTrap.Location.X;
                int tmpCoverY = labelHead.Location.Y  - labelTrap.Location.Y;
                if (tmpCoverY == 0 && tmpCoverX == 0)
                {
                    MessageBox.Show("Damage", "lose", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    game = false;
                }
            }

        }
        private void Timer(object sender, EventArgs e)
        {
            if (game == true)
            {
                Follow(labelEnemy2, EventArgs.Empty);
                Follow(labelEnemy, EventArgs.Empty);
            }
            else
            {
                TimeEnemy.Stop();
                TimeEnemy.Enabled = false;
            }
        }
        private void Follow(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            if ((label.Location.X == labelHead.Location.X) && (label.Location.Y == labelHead.Location.Y))
            {
                game = false;
                TimeEnemy.Stop();
                TimeEnemy.Enabled = false;
                MessageBox.Show("you was eate", "lose", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int x, y;
                int myX, myY;
                myX = labelHead.Location.X;
                myY = labelHead.Location.Y;
                x = label.Location.X;
                y = label.Location.Y;
                if (y < 0)
                    y = this.Size.Height;
                if (y > this.Size.Height)
                    y = 0;
                if (x < 0)
                    x = this.Size.Width;
                if (x > this.Size.Width)
                    x = 0;

                if (myY == y)
                {
                    if (myX > x)
                        x += 5;
                    else
                        x -= 5;
                }
                else if (myX == x)
                {
                    if (myY > y)
                        y += 5;
                    else
                        y -= 5;
                }
                else
                {
                    if (myX > x)
                        x += 10;
                    else
                        x -= 10;
                    if (myY > y)
                        y += 10;
                    else
                        y -= 10;
                }
                label.Location = new System.Drawing.Point(x, y);
            }
        }
    }
}
