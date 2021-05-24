using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameFramework
{
    class MoveRight : MainMovement
    {
        private static MoveRight right;
        private MoveRight() { }
        public static MoveRight instance()
        {
            if (right == null)
            {
                right = new MoveRight();
            }
            return right;
        }
        public void ObjectMovement(PictureBox enemyBox, int grav)
        {
            enemyBox.Left += grav;
        }
    }
}
