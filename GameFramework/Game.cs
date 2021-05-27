using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;

namespace GameFramework
{
    public class Game
    {
        private static Game game;
        private static int gravity;
        private static ArrayList AllObjects = new ArrayList();
        private Game(int grav) {
            gravity = grav;
        }
        public static Game instance(int grav) {
            if (game==null) {
                game = new Game(grav);
            }
            return game;
        } 
        public void AddObject(GameObject objectName) {
            AllObjects.Add(objectName);
        }
        public void RenderMovement() { 
            for (int index=0; index<AllObjects.Count;index++) {
                GameObject gameobj = (GameObject)AllObjects[index];
                gameobj.AlterPosition(gravity);
            }
        }
    } 
}
