using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameFramework
{
    public partial class GameForm : Form
    {
        private Game game;
        public GameForm()
        {
            InitializeComponent();
        }

        private void GameLoad(object sender, EventArgs e)
        {
            game = Game.instance(10);
            GameObject enemy01 = new GameObject(pictureBox1,new MoveRight());
            GameObject enemy02 = new GameObject(pictureBox2, new MoveLeft());
            GameObject enemy03 = new GameObject(pictureBox3, new HorizontalPatrol());
            GameObject enemy04 = new GameObject(pictureBox4, new MoveUp());
            GameObject enemy05 = new GameObject(pictureBox5, new Falling());
            game.AddObject(enemy01);
            game.AddObject(enemy02);
            game.AddObject(enemy03);
            game.AddObject(enemy04);
            game.AddObject(enemy05);
        }

        private void MainGameLoop(object sender, EventArgs e)
        {
            game.RenderMovement();
        }
    }
}
