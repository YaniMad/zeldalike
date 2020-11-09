using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarcoSan : MonoBehaviour
{   
    public Rigidbody2D rb2D;
    public float speed = 1f;

    private bool isGoingRight = true;
    private bool isGoingDown = true;
    public float timeToChangeDirection = 2f;
    private float chrono = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        chrono = chrono + Time.fixedDeltaTime;
        if (isGoingRight == true)
        {   
            rb2D.MovePosition(this.transform.position + speed * Vector3.right);
        }else
        {
            rb2D.MovePosition(this.transform.position + speed * Vector3.left);
        }

       /* if (isGoingDown == true)
        {   
            rb2D.MovePosition(this.transform.position + speed * Vector3.down);
        }else
        {
            rb2D.MovePosition(this.transform.position + speed * Vector3.up);
        }
*/
        if (chrono > timeToChangeDirection)
        {
            isGoingRight = !isGoingRight;
            isGoingDown = !isGoingDown;

            chrono = 0f;
        }
    }
}
