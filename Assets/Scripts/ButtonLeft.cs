using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLeft : MonoBehaviour {

    static private int speed = 10;
    public Transform player;
    Vector3 posPlayer;
    private bool OnMouseDrag_ = false; 
    public void Start()
    {
        
    }
    public void Update()
    {
        if (OnMouseDrag_ == true)
        {
            player.transform.position += Vector3.left * speed * Time.deltaTime;
        }
    }

    
    public void OnMouseDrag()
    {
        OnMouseDrag_ = true;
        player.transform.Rotate(Vector3.left);
          
    }
    public void OnMouseUp()
    {
        OnMouseDrag_ = false;
    }
}
