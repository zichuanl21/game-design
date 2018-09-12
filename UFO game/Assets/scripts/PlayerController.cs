using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
    public float speed;

    public Text ctext;

    public Text wtext;

    private int c;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D> ();
        c = 0;
        wtext.text = "";
        setCount();

    }

    // Update is called once per frame
    void FixedUpdate () {

        float movehorizontal = Input.GetAxis("Horizontal");
        float movevertical = Input.GetAxis("Vertical");
        Vector2 mv = new Vector2(movehorizontal, movevertical);
        rb.AddForce(mv *speed);
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PickUp"))
        {
            collision.gameObject.SetActive(false);
            c += 1;
            setCount();
        }
    }

    void setCount()
    {
        ctext.text = "Count :" + c.ToString();
        if (c>=5)
        {
            wtext.text = "You Win!";
        }
    }
}
