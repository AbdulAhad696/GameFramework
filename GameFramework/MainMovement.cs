using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameFramework
{
    public interface IMainMovement
    {

        MovementType GetMovement();
        void ObjectMovement(PictureBox enemyBox, int grav);
    }
}
