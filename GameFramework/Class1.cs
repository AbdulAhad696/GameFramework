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
    partial class Game : Form
    {
        
        private static ArrayList AllObjects = new ArrayList();
        public void AddObject(GameObject objectName) {
            AllObjects.Add(objectName);
        }
        public void RenderMovement() { 
            for (int index=0; index<AllObjects.Count;index++) {
                GameObject gameobj = (GameObject)AllObjects[index];
                gameobj.EnemyBox.Show();
                gameobj.EnemyBox.Top += gameobj.getGravity();
            }
        }
    }
}
