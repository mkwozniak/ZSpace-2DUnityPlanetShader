using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Wozware.ZSpaceDemo
{
    public class Rotate2D : MonoBehaviour
    {
        public float RotationSpeed;

        private void Update()
        {
            transform.Rotate(Vector3.forward * RotationSpeed * Time.deltaTime);
        }
    }
}

