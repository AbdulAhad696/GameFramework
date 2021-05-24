using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameFramework
{
    class Falling : MainMovement
    {
        private static Falling fall;
        private Falling() { }
        public static Falling instance()
        {
            if (fall == null)
            {
                fall = new Falling();
            }
            return fall;
        }
        public void ObjectMovement(PictureBox enemyBox, int grav)
        {
            enemyBox.Top += grav;
        }
    }
}
