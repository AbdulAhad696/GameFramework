using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework
{
    class FactoryPattern
    {
        private Game game;
        private static FactoryPattern factPat;
        private GameForm gameFormInstance;
        private FactoryPattern() { }
        public static FactoryPattern instance() {
            if (factPat == null){
                factPat = new FactoryPattern();
            }
            return factPat;
        }
        public void MakeObjects(){
            ObjectFactory objfactory = ObjectFactory.instance();
            game = Game.instance(10);
            gameFormInstance = GameForm.instance();
            GameObject enemy01 = objfactory.getObject(ObjectType.DragonShip, MovementType.Right);
            GameObject enemy02 = objfactory.getObject(ObjectType.DragonShip, MovementType.Left);
            GameObject enemy03 = objfactory.getObject(ObjectType.GorgShip, MovementType.Patrol);
            GameObject enemy04 = objfactory.getObject(ObjectType.GorgShip, MovementType.Up);
            GameObject enemy05 = objfactory.getObject(ObjectType.DragonShip, MovementType.Falling);
            GameObject enemy06 = objfactory.getObject(ObjectType.Player, MovementType.KeyboardInput);
            game.AddObject(enemy01);
            game.AddObject(enemy02);
            game.AddObject(enemy03);
            game.AddObject(enemy04);
            game.AddObject(enemy05);
            game.AddObject(enemy06);
            gameFormInstance.Controls.Add(enemy01.GetPictBox());
            gameFormInstance.Controls.Add(enemy02.GetPictBox());
            gameFormInstance.Controls.Add(enemy03.GetPictBox());
            gameFormInstance.Controls.Add(enemy04.GetPictBox());
            gameFormInstance.Controls.Add(enemy05.GetPictBox());
            gameFormInstance.Controls.Add(enemy06.GetPictBox());
        }
    }
}
