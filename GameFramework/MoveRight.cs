using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameFramework
{
    public class MoveRight : IMainMovement
    {
        private static MovementType movement = MovementType.Right;
        public MovementType GetMovement()
        {
            return movement;
        }
        public void ObjectMovement(GameObject objBox, int grav)
        {
            objBox.GetPictBox().Left += grav;
        }
    }
}
