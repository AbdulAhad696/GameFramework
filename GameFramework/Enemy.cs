using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameFramework
{
    class Enemy
    {
        private ObjectType objectType;
        public Enemy(ObjectType objectType)
        {
            this.objectType = objectType;
            SetProperties();
        }
        private PictureBox pictBox = new PictureBox();
        private void SetProperties() {
            pictBox.BackColor = System.Drawing.Color.Transparent;
            pictBox.Visible = false;
            pictBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictBox.Size = new System.Drawing.Size(100, 50);
            pictBox.Location = new System.Drawing.Point(400,200);
            if (objectType == ObjectType.GorgShip) {
                pictBox.Image = global::GameFramework.Properties.Resources.redship;
            }
            else if (objectType == ObjectType.DragonShip) {
                pictBox.Image = global::GameFramework.Properties.Resources.DragonShip;
            }
            else if (objectType == ObjectType.Player) {
                pictBox.Image = global::GameFramework.Properties.Resources.PlayerShip;
            }
            
        }
        public PictureBox GetPictBox() {
            return pictBox;
        }
    }
}
