using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameFramework
{
    class Static : IMainMovement
    {
        private static Static stat;
        private Static() { }
        public static Static instance()
        {
            if (stat == null)
            {
                stat = new Static();
            }
            return stat;
        }
        private static MovementType movement = MovementType.Static;
        public MovementType GetMovement()
        {
            return movement;
        }
        public void ObjectMovement(GameObject objBox, int grav)
        {
            
        }
    }
}
