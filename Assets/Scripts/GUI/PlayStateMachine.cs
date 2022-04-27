using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayStateMachine : MonoBehaviour
{
    public void Play()
    {
        Time.timeScale = 1;
    }
    public void FastForward()
    {
        Time.timeScale = 2;
    }
    public void Pause()
    {
        Time.timeScale = 0;
    }
    public void Rewind()
    {
        
    }
}
