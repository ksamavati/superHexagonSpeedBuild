﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hexagon : MonoBehaviour
{

    public Rigidbody2D rb;
    public float shrinkSpeed = 3;
    public TextMesh scoreText;
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb.rotation = Random.Range(0f, 360f);
        transform.localScale = Vector3.one * 10f; 
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime;
    
        if (transform.localScale.x <= .05f) {
            Destroy(gameObject);
            score++;
            scoreText.text = score.ToString();
        }
    }
}
