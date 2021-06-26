using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameFramework
{
    public class DecreaseHealth : ICollisionBehaviour
    {
        public void CollisionEventAction(GameObject ObjectToHurt) {
            ObjectToHurt.DecreaseHealth(50);

        }
    }
}
