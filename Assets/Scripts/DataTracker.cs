﻿using UnityEngine;
using System.Collections;

public class DataTracker : MonoBehaviour {

    void Awake()
    {
        DontDestroyOnLoad(this);
    }
    public AudioSource audio;
    public AudioSource audio2;
    private int p1_item;
    private int p2_item;
    private int p3_item;
    private int p4_item;
    
    private int highScore;
    private float musicTime;
	// Use this for initialization
	void Start () {
        p1_item = 0;
        p2_item = 0;
        p3_item = 0;
        p4_item = 0;
        highScore = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (Application.loadedLevel > 2 && audio.isPlaying)
        {
            Debug.Log("Loading Music 2");
            audio.Stop();
            audio2.Play();
        }
        else if (Application.loadedLevel <= 2 && !audio.isPlaying)
        {
            audio2.Stop();
            audio.Play();
        }
        musicTime = audio.time;
	}

    public float continuePlay() {
        return musicTime;
    }

    public void setHighscore(int score)
    {
        highScore = score;
    }

    public int getHighScore()
    {
        return highScore;
    }

    public void assignItemNum(int player, int item)
    {
        if (player == 1)
        {
            p1_item = item;
        }
        else if (player == 2)
        {
            p2_item = item;
        }
        else if (player == 3)
        {
            p3_item = item;
        }
        else
        {
            p4_item = item;
        }
    }

    public int getItemNum(int player){
        if (player == 1)
        {
            return p1_item;
        }
        else if(player == 2)
        {
            return p2_item;
        }
        else if (player == 3)
        {
            return p3_item;
        }
        else
        {
            return p4_item;
        }
    }
}