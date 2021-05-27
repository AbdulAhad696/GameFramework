using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public  MovementType GetMovement()
        {
            return movement;
        }
        private static bool GoLeft, GoRight, GoDown, GoUp;
        public void ObjectMovement(PictureBox enemyBox, int grav) {
            
            MovePlayer(enemyBox,grav);
        }
        private void MovePlayer(PictureBox enemyBox,int grav) {
            if (GoLeft && enemyBox.Left > 10)
            {
                enemyBox.Left -= grav;
            }
            if (GoRight && enemyBox.Left < 716)
            {
                enemyBox.Left += grav;
            }
            if (GoUp && enemyBox.Top > 0)
            {
                enemyBox.Top -= grav;
            }
            if (GoDown && enemyBox.Top < 400)
            {
                enemyBox.Top += grav;
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
