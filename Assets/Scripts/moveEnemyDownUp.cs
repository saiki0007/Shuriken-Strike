using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moveEnemyDownUp : MonoBehaviour
{
    public float delta = 2.0f; 
    public float speed = 1.0f;
    public Button FreezeButton;
    bool isFreezed;
    Rigidbody2D rigidbody;
    private Vector3 startPos;

    void Start()
    {
        isFreezed = false;
        if(FreezeButton){
            FreezeButton.onClick.AddListener(freezeObjects);
        }
        startPos = transform.position;
    }

    void Update()
    {
        if(!isFreezed){
            Vector3 v = startPos;
            v.y += delta * Mathf.PingPong(Time.time * speed, 1) * (-1);
            transform.position = v;
        }
        else {
            FreezeButton.interactable = false;
        }
    }
    void freezeObjects()
    {
        isFreezed = true;
    }
}
