using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace GameFramework
{
    public class KeyBoardInput : IMainMovement
    {
        private static MovementType movement = MovementType.KeyboardInput;
        private static KeyBoardInput KeyIn;
        private KeyBoardInput() { }
        public static KeyBoardInput instance() {
            if (KeyIn==null) {
                KeyIn = new KeyBoardInput();
            }
            return KeyIn;
        }
        private GameObject gameobj;
        public  MovementType GetMovement()
        {
            return movement;
        }
        private static bool GoLeft, GoRight, GoDown, GoUp,FireWeapon;
        public void ObjectMovement(GameObject objBox, int grav) {
            this.gameobj = objBox;
            MovePlayer(objBox,grav);
        }
        private void MovePlayer(GameObject objBox, int grav) {
            PictureBox pictBox = objBox.GetPictBox();

            if (GoLeft && pictBox.Left > 10)
            {
                pictBox.Left -= grav;
            }
            if (GoRight && pictBox.Left < 1900)
            {
                pictBox.Left += grav;
            }
            if (GoUp && pictBox.Top > 0)
            {
                pictBox.Top -= grav;
            }
            if (GoDown && pictBox.Top < 400)
            {
                pictBox.Top += grav;
            }
            if (FireWeapon) {
                GameObject weapon=objBox.ReturnWeapon();
                PictureBox weaponBox = weapon.GetPictBox();
                weaponBox.Show();
                
                weaponBox.Top -= grav;
                if (weaponBox.Top+56<0) {
                    weaponBox.Hide();
                    weaponBox.Location = new Point(-500, -200);
                    FireWeapon = false;
                }
            }
        }
        public void KeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Left) {
                GoLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                GoRight = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                GoUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                GoDown = true;
            }
            if (e.KeyCode == Keys.Space && FireWeapon==false) {
                FireWeapon = true;
                PictureBox pictBox = gameobj.GetPictBox();
                GameObject weapon = gameobj.ReturnWeapon();
                PictureBox weaponBox = weapon.GetPictBox();
                weaponBox.Show();
                weaponBox.Location = new Point(pictBox.Location.X + 50, pictBox.Location.Y + 35);
            }
        }
        public void KeyUpEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Left) {
                GoLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                GoRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                GoUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                GoDown = false;
            }
        }
    }
}
