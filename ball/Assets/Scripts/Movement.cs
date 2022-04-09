using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float maximumX;
    float posY;
    void Start()
    {
        posY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        Vector2 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        float mousePosX = Mathf.Clamp(mousePos.x,-maximumX,maximumX);
        float movement = Mathf.Lerp(transform.position.x, mousePosX,10* Time.deltaTime);
        transform.position = new Vector2(movement, transform.position.y);
    }
}
