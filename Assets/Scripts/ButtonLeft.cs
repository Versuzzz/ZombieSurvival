using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLeft : MonoBehaviour {

    static private int speed = 20;
    public Transform Hero;

    public void OnMouseDrag()
    {
        Vector3 position = Hero.position;
        Hero.position = Vector2.MoveTowards(Hero.position, new Vector2(position.x, position.y), speed * Time.deltaTime);
    }
}
