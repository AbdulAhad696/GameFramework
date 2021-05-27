using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameFramework
{
    public class MoveUp : IMainMovement
    {
        private static MovementType movement = MovementType.Up;
        public  MovementType GetMovement(){
            return movement;
        }
        public void ObjectMovement(PictureBox enemyBox, int grav)
        {
            enemyBox.Top -= grav;
        }
        
    }
}
