using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shooter
{
    public class PlayerMovement : MonoBehaviour
    {
        private Vector3 direction;
        [SerializeField]private float speed =.1f;
        // Start is called before the first frame update
       private void Start()
        {

        }

        // Update is called once per frame
        private void Update()
        {
            //считываем оси 
            direction.x = Input.GetAxis("Horizontal");
            direction.z = Input.GetAxis("Vertical");
            transform.position += direction*speed;
        }
    }
}
