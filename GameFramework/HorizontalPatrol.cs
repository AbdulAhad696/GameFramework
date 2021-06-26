using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameFramework
{
    public class HorizontalPatrol : IMainMovement
    {
        private static MovementType movement = MovementType.Patrol;
        public MovementType GetMovement()
        {
            return movement;
        }
        private static int functionCall = 0;
        public void ObjectMovement(GameObject objBox, int grav)
        {
            if ((functionCall / 120) % 2 == 0)
            {
                objBox.GetPictBox().Left -= grav;
            }
            else
            {
                objBox.GetPictBox().Left += grav;
            }
            functionCall += 1;
        }
    }
}
