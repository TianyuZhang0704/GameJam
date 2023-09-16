using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WasteCan : MonoBehaviour
{
    public UpdateUI updateUI;

    // Start is called before the first frame update
    void Start()
    {
        updateUI = GameObject.FindObjectOfType<UpdateUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 1f)
        {
            Destroy(gameObject);
            updateUI.AddScore();
        }
    }
}
