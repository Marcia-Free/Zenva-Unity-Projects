using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonController : MonoBehaviour
{
    public int clicksToPop = 3;

    private void OnMouseDown()
    {
        clicksToPop--;

        //increases the balloon's scale per click
        transform.localScale += new Vector3(0.5f, 0.5f, 0.5f);

        //when this reaches 0 it destroys the balloon
        if (clicksToPop == 0)
        {
            Destroy(gameObject);
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
