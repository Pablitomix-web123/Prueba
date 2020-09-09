using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepintinBackground : MonoBehaviour
{
    private BoxCollider2D groundCollider;
    private float groundHorizontalLegth;
    private void Awake()
    {
        groundCollider = GetComponent<BoxCollider2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        groundHorizontalLegth = groundCollider.size.x;
    }

    private void RepositioBackground() 
    {
        transform.Translate(Vector2.right * groundHorizontalLegth * 2);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -groundHorizontalLegth) 
        {
            RepositioBackground();
        }
        
    }
}
