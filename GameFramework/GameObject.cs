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
    class GameObject
    {
        private PictureBox EnemyBox;
        private MainMovement movement;
        public GameObject(PictureBox EnemyBox,MainMovement movement) 
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
        
    }
}
