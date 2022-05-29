using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public Rigidbody ball;
    public Transform shootPos;
    public float shootForce = 5000f;
    public float moveSpeed = 50f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //float h = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        //float v = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(new Vector3(0, 0, 0f));

        if(Input.GetButtonUp("Fire1"))
        {
            Rigidbody shoot = Instantiate(ball, shootPos.position, shootPos.rotation) as Rigidbody;
            shoot.AddForce(shootPos.forward * shootForce);

            //Destroy(shoot.gameObject, 5f);
        }
    }
}
