using Assets.Vessels;
using Assets.Vessels.Movement;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Submarine : Vessel
{
    const string _tagNameConstant = "Submarine";
    const float _movementSpeed = 1f;
    private Movement _movement = new Movement();


    /// <summary>
    /// Monobehavior start: Start is called before the first frame update
    /// </summary>
    public override void Start()
    {
        GameObject gameObject = new GameObject();
        gameObject.tag = _tagNameConstant;
    }

    /// <summary>
    /// Monobehavior Update: Update is called once per frame
    /// </summary>
    public override void Update()
    {
        _movement.MovementDirection();
        this.Move();
    }

    /// <summary>
    /// Implements Attack behavior.
    /// </summary>
    public override void Attack()
    {
        throw new System.NotImplementedException();
    }

    /// <summary>
    /// Implements Submarine movement.
    /// Takes Horizontal/Vertical input from user and applies to x,y axes (ignoring z).
    /// deltaTime ensures frames are consistent between devices.
    /// </summary>
    /// <param name="moveSpeed"></param>
    public override void Move()
    {
        transform.Translate(_movementSpeed * _movement.getHorizontalMovementDirection() * Time.deltaTime, _movementSpeed * _movement.getVerticalMovementDirection() * Time.deltaTime, 0f);
        
    }

    /// <summary>
    /// Implements Sinking behavior.
    /// </summary>
    /// <param name="sinkSpeed"></param>
    public override void Sink(float sinkSpeed)
    {
        throw new System.NotImplementedException();
    }

    /// <summary>
    /// If Submarine hits boundary, move object in opposite direction
    /// </summary>
    /// <param name="collision"></param>
    public override void OnCollisionEnter2D(Collision2D collision)
    {
        switch(collision.collider.name)
        {
            case "LeftBoundary":
                _movement.MovementDirection(1f, _movement.getVerticalMovementDirection());
                break;
            case "RightBoundary":
                _movement.MovementDirection(-1f, _movement.getVerticalMovementDirection());
                break;
            case "LowerBoundary":
                _movement.MovementDirection(_movement.getHorizontalMovementDirection(), 1f);
                break;
            case "UpperBoundary":
                _movement.MovementDirection(_movement.getHorizontalMovementDirection(), -1f);
                break;
            default:
                throw new Exception("Collision happened with no defined object!");
        }
    }
}
