using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
namespace GameFramework
{
    public class GameObject
    {
        private PictureBox pictBox;
        private IMainMovement movement;
        private ObjectType objType;
        private int ObjectHealth = 100;
        private GameObject weapon;
        internal GameObject(PictureBox EnemyBox,IMainMovement movement,ObjectType objectType) 
        {
            this.objType = objectType;
            this.pictBox = EnemyBox;
            this.movement = movement;
            if (objectType == ObjectType.GorgShip)
            {
                ObjectHealth = 50;
            }
        }
        //
        //overloading the constructor
        //
        internal GameObject(PictureBox EnemyBox, IMainMovement movement, ObjectType objectType,GameObject myweapon)
        {
            this.weapon = myweapon;
            this.objType = objectType;
            this.pictBox = EnemyBox;
            this.movement = movement;
            if (objectType == ObjectType.GorgShip)
            {
                ObjectHealth = 50;
            }
        }
        public void AlterPosition(int gravity)   
        {
            pictBox.Show();
            movement.ObjectMovement(this,gravity);
        }
        public GameObject ReturnWeapon() {
            return weapon;
        }
        public ObjectType GetobjType() {
            return objType;
        }
        public PictureBox GetPictBox() {
            return pictBox;
        }
        public void DecreaseHealth(int loss) {
            ObjectHealth -= loss;
            if (ObjectHealth==0) {
                pictBox.Hide();
                pictBox.Location = new Point(-200,-200);
                Game.removeObject(this);
                GC.Collect(GC.GetGeneration(this));
            }

        }
        // Destructor
        ~GameObject()
        {
            PoolPattern poolpat = PoolPattern.instance();
            poolpat.DeleteObject(this.movement);
        }
    }
}
