using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace GameFramework
{
    class FactoryPattern
    {
        
        private static FactoryPattern factPat;
        private static int[] CountArray = { 0,0,0,0};
        private FactoryPattern() { }
        public static FactoryPattern instance() {
            if (factPat == null){
                factPat = new FactoryPattern();
            }
            return factPat;
        }
        public GameObject MakeObjects(PictureBox pictBox,MainMovement movement,ObjectType objectType1){
            
            CountArray[objectType1.GetHashCode()] += 1;
            
            return new GameObject(pictBox,movement);
        }
    }
}
