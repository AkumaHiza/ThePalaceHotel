using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Points : MonoBehaviour
{
    public int points;
    public Text mypoints;
    public Text myminutes;
    public Text myseconds;
    private float timeLeft;
    private int minutes;
    private int seconds;
    // Start is called before the first frame update
    void Start()
    {
        points = 0;
        timeLeft = 120.0f;
    }

    // Update is called once per frame
    void Update()
    {
      timeLeft -= Time.deltaTime;
      minutes = (int)timeLeft / 60;
      seconds = (int) timeLeft - 60 * minutes;
      myminutes.text = minutes.ToString();
      myseconds.text = seconds.ToString();
      if(timeLeft <= 0) SceneManager.LoadScene(2); //YOU LOSE
      mypoints.text = points.ToString();
      if(points == 10) SceneManager.LoadScene(3); //YOU WIN
    }
}
