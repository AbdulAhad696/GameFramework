using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameFramework
{
    public class Falling : IMainMovement
    {
        private static MovementType movement = MovementType.Falling;
        public MovementType GetMovement()
        {
            return movement;
        }
        public void ObjectMovement(GameObject objBox, int grav)
        {
            objBox.GetPictBox().Top += grav;
        }
    }
}
