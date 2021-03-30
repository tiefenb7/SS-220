using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Vessels.Movement
{
    public class Movement
    {
        private float _movementDirectionHorizontal = 0f;
        private float _movementDirectionVertical = 0f;

        /// <summary>
        /// Get Horizontal Movement Direction
        /// </summary>
        /// <returns></returns>
        public float getHorizontalMovementDirection() => _movementDirectionHorizontal;

        /// <summary>
        /// Get Vertical Movement Direction
        /// </summary>
        /// <returns></returns>
        public float getVerticalMovementDirection() => _movementDirectionVertical;

        /// <summary>
        /// Strictly sets horizontal/veritcal movement direction
        /// </summary>
        /// <param name="moveHorizontalDirection"></param>
        /// <param name="moveVerticalDirection"></param>
        public void MovementDirection(float moveHorizontalDirection, float moveVerticalDirection)
        {
            _movementDirectionHorizontal = moveHorizontalDirection;
            _movementDirectionVertical = moveVerticalDirection;
        }

        /// <summary>
        /// Sets movement directiom based on User Input
        /// </summary>
        public void MovementDirection()
        {
            if (Input.GetKeyUp(KeyCode.LeftArrow))
            {
                _movementDirectionHorizontal = -1f;
            }
            if (Input.GetKeyUp(KeyCode.RightArrow))
            {
                _movementDirectionHorizontal = 1f;
            }
            if (Input.GetKeyUp(KeyCode.DownArrow))
            {
                _movementDirectionVertical = -1f;
            }
            if (Input.GetKeyUp(KeyCode.UpArrow))
            {
                _movementDirectionVertical = 1f;
            }
        }
    }
}
