using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameFramework
{
    class MoveUp : MainMovement
    {
        private static MoveUp up;
        private MoveUp() { }
        public static MoveUp instance() {
            if (up == null ) {
                up = new MoveUp();
            }
            return up;
        }
        public void ObjectMovement(PictureBox enemyBox, int grav)
        {
            enemyBox.Top -= grav;
        }
    }
}
