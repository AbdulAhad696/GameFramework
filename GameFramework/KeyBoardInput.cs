using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameFramework
{
    class KeyBoardInput : MainMovement
    {
        private static bool GoLeft, GoRight, GoDown, GoUp;
        private static KeyBoardInput keyInput;
        private KeyBoardInput(){}
        
        public static KeyBoardInput instance() {
            if (keyInput == null){
                keyInput = new KeyBoardInput();
            }
            return keyInput;
        }
        public void ObjectMovement(PictureBox enemyBox, int grav) {
            GameForm gameForm = GameForm.instance();
            gameForm.KeyDown += new System.Windows.Forms.KeyEventHandler(KeyDownEvent);
            gameForm.KeyUp += new System.Windows.Forms.KeyEventHandler(KeyUpEvent);
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
        private void KeyDownEvent(object sender, KeyEventArgs e)
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
        private void KeyUpEvent(object sender, KeyEventArgs e)
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
