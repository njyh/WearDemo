using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpRoleInfoCtrl : MonoBehaviour
{
    public ProgressBar p;

    private int value;

    public void setValue(int value){
        p.SetProgress(value);
    }

    public int getValue(){
        return Mathf.RoundToInt(p.slider.value);
    }
}
