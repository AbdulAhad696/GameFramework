using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameFramework
{
    class ObjectFactory
    {
        private static int GorgShipCount=0;
        private static int DragonShipCount=0;
        private static ObjectFactory objFact;
        private ObjectFactory(){}
        public static ObjectFactory instance() {
            if (objFact == null){
                objFact = new ObjectFactory();
            }
            return objFact;
        }
        public GameObject getObject(ObjectType objectType,MovementType movementType) {
            
            if (objectType == ObjectType.DragonShip) {
                Enemy ene1 = new Enemy(objectType);
                DragonShipCount += 1;
                if (movementType==MovementType.Right) {
                    return new GameObject(ene1.GetPictBox(), MoveRight.instance());
                }
                else if (movementType == MovementType.Up)
                {
                    return new GameObject(ene1.GetPictBox(),MoveUp.instance());
                }
                else if (movementType == MovementType.Left)
                {
                    return new GameObject(ene1.GetPictBox(), MoveLeft.instance());
                }
                else if (movementType == MovementType.Falling)
                {
                    return new GameObject(ene1.GetPictBox(), Falling.instance());
                }
                else if (movementType == MovementType.Patrol)
                {
                    return new GameObject(ene1.GetPictBox(), HorizontalPatrol.instance());
                }
            }
            else if (objectType == ObjectType.GorgShip)
            {
                Enemy ene1 = new Enemy(objectType);
                GorgShipCount += 1;
                if (movementType == MovementType.Right)
                {
                    return new GameObject(ene1.GetPictBox(), MoveRight.instance());
                }
                else if (movementType == MovementType.Up)
                {
                    return new GameObject(ene1.GetPictBox(),MoveUp.instance());
                }
                else if (movementType == MovementType.Left)
                {
                    return new GameObject(ene1.GetPictBox(), MoveLeft.instance());
                }
                else if (movementType == MovementType.Falling)
                {
                    return new GameObject(ene1.GetPictBox(), Falling.instance());
                }
                else if (movementType == MovementType.Patrol)
                {
                    return new GameObject(ene1.GetPictBox(), HorizontalPatrol.instance());
                }
            }
            else if (objectType == ObjectType.Player) {
                Enemy ene1 = new Enemy(objectType);
                return new GameObject(ene1.GetPictBox(),KeyBoardInput.instance());
            }
            return null;
        }
    }
}
