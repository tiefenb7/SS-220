using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Vessels
{
    public abstract class Vessel : MonoBehaviour
    {

        // Start is called before the first frame update
        public abstract void Start();

        // Update is called once per frame
        public abstract void Update();

        /// <summary>
        /// Define Behavior for Machine Movement
        /// </summary>
        public abstract void Move();
        
        /// <summary>
        /// Define Behavior for Attack
        /// </summary>
        public abstract void Attack();

        /// <summary>
        /// Define Behavior for Sinking after attack hit
        /// </summary>
        public abstract void Sink(float sinkSpeed);

        /// <summary>
        /// Define Behavior for Collisions
        /// </summary>
        public abstract void OnCollisionEnter2D(Collision2D coll);


    }
}
