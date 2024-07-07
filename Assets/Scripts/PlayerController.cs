using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount = 3f;
    [SerializeField] Rigidbody2D rb2d;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        HandleMovement();
    }

    void HandleMovement() {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(torqueAmount);
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(-torqueAmount);
        }
        if (Input.GetKeyDown(KeyCode.Space)){
            rb2d.AddForce(new Vector2(0,10000 * Time.deltaTime));
            Debug.Log("Jump");
        }
    }

}
