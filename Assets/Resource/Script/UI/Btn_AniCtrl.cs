using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Btn_AniCtrl : MonoBehaviour
{
    public Animation ani;
    public string normal;
    public string highlight;
    public string pressed;
    public string pressEnded;

    public void onNormal()
    {
        ani.Play(normal);
    }

    public void onHighLight()
    {
        ani.Play(highlight);
    }

    public void onPressed()
    {
        ani.Play(pressed);
    }

    public void onPressEnded()
    {
        ani.Play(pressEnded);
    }
}
