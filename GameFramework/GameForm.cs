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
        private static GameForm gameFormInstance;
        private Game game;
        private FactoryPattern factory;
        private GameForm()
        {
            InitializeComponent();
        }
        public static GameForm instance() {
            if (gameFormInstance == null){
                gameFormInstance = new GameForm();
            }
            return gameFormInstance;
        }

        private void GameLoad(object sender, EventArgs e)
        {
            factory = FactoryPattern.instance();
            
            ObjectFactory objfactory = ObjectFactory.instance();
            game = Game.instance(10);
            gameFormInstance = GameForm.instance();
            GameObject enemy01 = factory.MakeObjects(pictureBox1, MoveLeft.instance(), ObjectType.DragonShip);
            GameObject enemy02 = factory.MakeObjects(pictureBox2, MoveRight.instance(), ObjectType.DragonShip);
            GameObject enemy03 = factory.MakeObjects(pictureBox3, HorizontalPatrol.instance(), ObjectType.DragonShip);
            GameObject enemy04 = factory.MakeObjects(pictureBox4, MoveUp.instance(), ObjectType.DragonShip);
            GameObject enemy05 = factory.MakeObjects(pictureBox5, Falling.instance(), ObjectType.DragonShip);
            GameObject enemy06 = factory.MakeObjects(pictureBox6, KeyBoardInput.instance(), ObjectType.DragonShip);
            game.AddObject(enemy01);
            game.AddObject(enemy02);
            game.AddObject(enemy03);
            game.AddObject(enemy04);
            game.AddObject(enemy05);
            game.AddObject(enemy06);
        }

        private void MainGameLoop(object sender, EventArgs e)
        {
            game = Game.instance(10);
            game.RenderMovement();
        }
    }
}
