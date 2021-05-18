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
    class GameObject : Form
    {
        private int Gravity;
        private string State =  "Falling";
        public PictureBox EnemyBox = new PictureBox();
        public GameObject(System.Windows.Forms.PictureBox boxname,int gravity) {
            Gravity = gravity;
            EnemyBox = boxname;
        }
        public int getGravity() {
            return Gravity;
        }
    }
}
