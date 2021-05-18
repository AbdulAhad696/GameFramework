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
        public PictureBox EnemyBox = new PictureBox();
        public GameObject(PictureBox boxname) 
        {
            EnemyBox = boxname;
        }
        public void AlterPosition(int gravity) {
            EnemyBox.Top += gravity;
        }
    }
}
