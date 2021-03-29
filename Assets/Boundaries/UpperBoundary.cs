using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Boundaries
{
    public class UpperBoundary : MonoBehaviour
    {
        const string _tagNameConstant = "UpperBoundary";

        /// Monobehavior start: Start is called before the first frame update
        /// </summary>
        public void Start()
        {
            GameObject gameObject = new GameObject();
            gameObject.tag = _tagNameConstant;
        }

        /// <summary>
        /// Monobehavior Update: Update is called once per frame
        /// </summary>
        public void Update()
        {

        }
    }
}
