using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameFramework
{
    public class CollisionDetection
    {
        private GameObject ObjectEffecting;
        private GameObject ObjectEffected;
        private PictureBox pictBox1;
        private PictureBox pictBox2;
        private ICollisionBehaviour collision;
        public CollisionDetection(GameObject ObjectEffecting, GameObject ObjectEffected, BehaviourType collisiontype) {
            this.ObjectEffecting = ObjectEffecting;
            this.ObjectEffected = ObjectEffected;
            pictBox1 = ObjectEffecting.GetPictBox();
            pictBox2 = ObjectEffected.GetPictBox();
            if (collisiontype == BehaviourType.Die)
            {
                this.collision = new KillObject();
            }
            else if (collisiontype == BehaviourType.HealthDecrease) {
                this.collision = new DecreaseHealth();
            }
        }
        public void Detect() {
            if (pictBox1.Bounds.IntersectsWith(pictBox2.Bounds)) {
                collision.CollisionEventAction(ObjectEffected);
            }
        }
    }
}
