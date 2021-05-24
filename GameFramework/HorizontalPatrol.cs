using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameFramework
{
    class HorizontalPatrol : MainMovement
    {
        private static HorizontalPatrol patrol;
        private HorizontalPatrol() { }
        public static HorizontalPatrol instance()
        {
            if (patrol == null)
            {
                patrol = new HorizontalPatrol();
            }
            return patrol;
        }
        private static int functionCall = 0;
        public void ObjectMovement(PictureBox enemyBox, int grav)
        {
            if ((functionCall / 30) % 2 == 0)
            {
                enemyBox.Left -= grav;
            }
            else
            {
                enemyBox.Left += grav;
            }
            functionCall += 1;
        }
    }
}
