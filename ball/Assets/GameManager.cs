using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TMP_Text text;
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<Movement>().GetComponent<Movement>().enabled = false;
        FindObjectOfType<Ball>().GetComponent<Ball>().enabled = false;
        FindObjectOfType<Ball>().GetComponent<Rigidbody2D>().isKinematic = true;
        text.text = "Tap to Play";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            FindObjectOfType<Movement>().GetComponent<Movement>().enabled = true;
            FindObjectOfType<Ball>().GetComponent<Ball>().enabled = true;
            FindObjectOfType<Ball>().GetComponent<Rigidbody2D>().isKinematic = false;
            text.text = "";
        }
    }
}
