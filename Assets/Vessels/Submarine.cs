using Assets.Vessels;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Submarine : Vessel
{
    const string _tagNameConstant = "Submarine";

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
        this.Move(1f);
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
    public override void Move(float moveSpeed)
    {
        transform.Translate(moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime, 0f);
    }

    /// <summary>
    /// Implements Sinking behavior.
    /// </summary>
    /// <param name="sinkSpeed"></param>
    public override void Sink(float sinkSpeed)
    {
        throw new System.NotImplementedException();
    }

    public override void OnCollisionEnter2D(Collision2D collision)
    {
        switch(collision.collider.name)
        {
            case "LeftBoundary":
                Debug.Log("Collided with Left Boundary");
                break;
            case "RightBoundary":
                Debug.Log("Collided with Right Boundary");
                break;
            case "LowerBoundary":
                Debug.Log("Collided with Lower Boundary");
                break;
            case "UpperBoundary":
                Debug.Log("Collided with Upper Boundary");
                break;
            default:
                throw new Exception("Collision happened with no defined object!");
        }
    }
}
