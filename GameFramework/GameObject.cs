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
        private PictureBox EnemyBox;
        private IMainMovement movement;
        internal GameObject(PictureBox EnemyBox,IMainMovement movement) 
        {
            this.EnemyBox = EnemyBox;
            this.movement = movement;
        }
        public void AlterPosition(int gravity)   
        {
            EnemyBox.Show();
            movement.ObjectMovement(EnemyBox,gravity);
        }
        public PictureBox GetPictBox() {
            return EnemyBox;
        }
        // Destructor
        ~GameObject()
        {
            PoolPattern poolpat = PoolPattern.instance();
            poolpat.DeleteObject(this);
        }
    }
}
