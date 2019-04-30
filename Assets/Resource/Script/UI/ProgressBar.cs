using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour {
    
    public Slider slider;
    public int index;
    public float speed;
    public GameObject fill;
    
    private void Awake() {
        slider = GetComponent<Slider>();
    }

    private void Update() {
        if(slider.value == 0){
            fill.SetActive(false);
        }
    }

//Use SetProgress(progress,speed) instead of change the value of slider directly.
    public void SetProgress(int progress) => StartCoroutine(ChangeProgress(progress,index));

    public int GetProgress() => Mathf.RoundToInt(slider.value);

    IEnumerator ChangeProgress(int progress,int index){
        while(Mathf.Abs(slider.value - progress) > index){
            yield return 0;
            if(progress > Mathf.Round(slider.value)){
                slider.value = Mathf.Lerp(slider.value,progress,speed);
            }else if(progress < Mathf.Round(slider.value))
            {
                slider.value = Mathf.Lerp(progress,slider.value,speed);
            }
        }

        slider.value = progress;
    }
}