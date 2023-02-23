namespace Wozware.ZSpaceDemo
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class Rotate2D : MonoBehaviour
    {
        public float RotationSpeed;

        private void Update()
        {
            transform.Rotate(Vector3.forward * RotationSpeed * Time.deltaTime);
        }
    }
}

