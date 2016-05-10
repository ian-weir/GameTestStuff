using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Movement();
	}

    void Movement() {
        int speed = 12;
        Vector2 jumpHeight = new Vector2(0, 1);


        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 0);
        } else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);  //vector2.Right because of the flip done on the next line
            transform.eulerAngles = new Vector2(0, 180); //flips character model
        }

        if (Input.GetKey(KeyCode.W) && )
        {
            GetComponent<Rigidbody2D>().AddForce(jumpHeight, ForceMode2D.Impulse);
        }
    }
}
