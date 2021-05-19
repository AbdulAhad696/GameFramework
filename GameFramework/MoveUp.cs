﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameFramework
{
    class MoveUp : ParentMovement
    {
        public override void ObjectMovement(PictureBox enemyBox, int grav)
        {
            enemyBox.Top -= grav;
        }
    }
}