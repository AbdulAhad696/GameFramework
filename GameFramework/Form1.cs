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
    public partial class Form1 : Form
    {
        private Game gameForm;
        public Form1()
        {
            InitializeComponent();
        }

        private void GameLoad(object sender, EventArgs e)
        {
            gameForm = new Game();
            GameObject enemy01 = new GameObject(pictureBox1,5);
            GameObject enemy02 = new GameObject(pictureBox2, 5);
            GameObject enemy03 = new GameObject(pictureBox3, 15);
            GameObject enemy04 = new GameObject(pictureBox4, 10);
            GameObject enemy05 = new GameObject(pictureBox5, 10);
            gameForm.AddObject(enemy01);
            gameForm.AddObject(enemy02);
            gameForm.AddObject(enemy03);
            gameForm.AddObject(enemy04);
            gameForm.AddObject(enemy05);

        }

        private void MainGameLoop(object sender, EventArgs e)
        {
            gameForm.RenderMovement();
        }
    }
}
