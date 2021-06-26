using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace GameFramework
{
    public class PoolPattern
    {
        private static ArrayList FreeObjects = new ArrayList();
        private static ArrayList OccupiedObjects = new ArrayList();
        private static PoolPattern PoolPat;
        private IMainMovement movement;
        private PoolPattern() { }
        public static PoolPattern instance()
        {
            if (PoolPat == null)
            {
                PoolPat = new PoolPattern();
            }
            return PoolPat;
        }
        public IMainMovement GetResource(MovementType movementType) {
            for (int index=0;index<FreeObjects.Count;index++) { 
                movement = (IMainMovement)FreeObjects[index];
                if (movementType==movement.GetMovement()) {
                    OccupiedObjects.Add(movement);
                    FreeObjects.RemoveAt(index);
                    return movement;
                }
            }
            if (movementType == MovementType.Right) {
                movement = new MoveRight();
            }
            else if (movementType == MovementType.Left)
            {
                movement = new MoveLeft();
            }
            else if (movementType == MovementType.Up)
            {
                movement = new MoveUp();
            }
            else if (movementType == MovementType.Falling)
            {
                movement = new Falling();
            }
            else if (movementType == MovementType.KeyboardInput)
            {
                for (int index=0;index<OccupiedObjects.Count;index++) {
                    movement = (IMainMovement)OccupiedObjects[index];
                    if (movementType == movement.GetMovement()) {
                        return Static.instance();
                    }
                }
                movement = KeyBoardInput.instance();
            }
            else if (movementType == MovementType.Patrol)
            {
                movement = new HorizontalPatrol();
            }
            OccupiedObjects.Add(movement);
            return movement;
        }
        public void DeleteObject(IMainMovement obj) {
            OccupiedObjects.Remove(obj);
            FreeObjects.Add(obj);
        }
    }
}