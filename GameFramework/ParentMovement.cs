using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameFramework
{
    abstract class ParentMovement
    {
        public abstract void ObjectMovement(PictureBox enemyBox, int grav);
    }
}
