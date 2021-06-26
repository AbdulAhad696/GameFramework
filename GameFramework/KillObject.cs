using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameFramework
{
    public class KillObject : ICollisionBehaviour
    {
        private PictureBox pictBox;
        public void CollisionEventAction(GameObject objectToKill) {
            pictBox=objectToKill.GetPictBox();
            pictBox.Hide();
            pictBox.Location = new Point(-200,-200);
            Game.removeObject(objectToKill);
            GC.Collect(GC.GetGeneration(objectToKill));
        }
    }
}
