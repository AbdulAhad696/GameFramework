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
        private static ArrayList AllCollisions = new ArrayList();
        private static bool gameend=false;
        private static int score;
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
        public void AddCollision(CollisionDetection collision) {
            AllCollisions.Add(collision);
        }
        public int getscore() {
            return score;
        }
        public static void removeObject(GameObject gameobj) {
            AllObjects.Remove(gameobj);
            if (gameobj.GetobjType()==ObjectType.DragonShip || gameobj.GetobjType() == ObjectType.GorgShip) {
                score += 100;
            }
            if (gameobj.GetobjType()==ObjectType.Player) {
                gameend = true;
            }
            if (AllObjects.Count<2) {
                gameend = true;
            }
        }
        public bool CheckStatus() {
            return gameend;
        }
        public void RenderMovement() { 
            for (int index=0; index<AllObjects.Count;index++) {
                GameObject gameobj = (GameObject)AllObjects[index];
                if (gameobj.GetobjType() != ObjectType.Missile)
                {
                    gameobj.AlterPosition(gravity);
                    foreach (CollisionDetection collision in AllCollisions)
                    {
                        collision.Detect();
                    }
                    if (gameobj.GetPictBox().Top + 100 > 1900)
                    {
                        removeObject(gameobj);
                    }
                }
            }
        }
    } 
}
