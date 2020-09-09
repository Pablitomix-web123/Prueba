using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrolingObject : MonoBehaviour
{
    private Rigidbody2D rb2D;
    // Start is called before the first frame update

    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        rb2D.velocity = new Vector2(GameControler.Instance.scrollSpeed, 0);
        //rb2D.velocity = Vector2.right * GameControler.Instance.scrollSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameControler.Instance.gameOver) 
        {
            rb2D.velocity = Vector2.zero;
        }
        
    }
}
