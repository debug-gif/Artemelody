using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using System;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public AudioSource beatMusic;
    public AudioSource myMusic;
    public bool startPlaying;
    public ∆Ã√Ê BS;
    public static GameManager instance;
    public float score;
    public float Scorepernote=1000;
    public TMP_Text scoreText;
    public TMP_Text multiplyText;
    public float multiply;
    public int multiplyTimes;
    public int baseNumber = 1;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        multiply = 0;
    }

    // Update is called once per frame
    void Update()
    {
        multiplyText.text = "Combo " + (multiply) + " ";
        if (!startPlaying)
        {
            if (Input.anyKeyDown)
            {
                startPlaying = true;
                BS.hasStart = true;
                myMusic.Play();
            }
        }
    }
    public void NoteHit()
    {
        Debug.Log("HIT");
        score += Scorepernote + multiply;
        multiplyTimes++;
        multiply = baseNumber  +multiplyTimes;
        multiply = (float)Math.Round((decimal)multiply, 1);
        scoreText.text = "Score: " + score;
        beatMusic.Play();
    }
    public void NoteMiss()
    {
        Debug.Log("MISS");
        multiplyTimes = 0;
        multiply = 0;
        beatMusic.Play();
    }
}

