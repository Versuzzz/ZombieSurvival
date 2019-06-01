using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPlay : MonoBehaviour {

    private string Scene = "Game";
    public void OnMouseDrag()
    {
        SceneManager.LoadScene(Scene);
    }
}
