using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace GameFramework
{
    public class FactoryPattern
    {
        private static FactoryPattern factPat;
        private static int[] CountArray = { 0,0,0,0,0};
        private IMainMovement movement;
        private FactoryPattern() { }
        public static FactoryPattern instance() {
            if (factPat == null){
                factPat = new FactoryPattern();
            }
            return factPat;
        }
        public GameObject MakeObjects(PictureBox pictBox,MovementType movementType1,ObjectType objectType1){
            PoolPattern poolpat = PoolPattern.instance();
            movement = poolpat.GetResource(movementType1);
            CountArray[objectType1.GetHashCode()] += 1;
            return new GameObject(pictBox,movement,objectType1);
        }
        //
        //overloading the function for adding a weapon to an object
        //
        public GameObject MakeObjects(PictureBox pictBox, MovementType movementType1, ObjectType objectType1,GameObject weapon)
        {
            PoolPattern poolpat = PoolPattern.instance();
            movement = poolpat.GetResource(movementType1);
            CountArray[objectType1.GetHashCode()] += 1;
            return new GameObject(pictBox, movement, objectType1,weapon);
        }
    }
}
