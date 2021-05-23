using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameFramework
{
    class MoveLeft : MainMovement
    {
        private static MoveLeft left;
        private MoveLeft() { }
        public static MoveLeft instance() {
            if (left==null) {
                left = new MoveLeft();
            }
            return left;
        }
        public void ObjectMovement(PictureBox enemyBox,int grav) {
            enemyBox.Left -= grav;
        }
    }
}
