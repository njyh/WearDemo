using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoleCtrl : MonoBehaviour
{
    public Image RoleImg;
    public Text RoleText;
    public Image ItemImg;
    public Text ItemText;
    public Image SkillImg;
    public Text SkillText;

    private bool isAutoHide = true;

    private void Start()
    {
        StartCoroutine(AutoHide());
    }

    public void SetRoleImage(Sprite img)
    {
        RoleImg.sprite = img;
    }

    public void SetItemImage(Sprite img)
    {
        ItemImg.sprite = img;
    }

    public void SetSkillImage(Sprite img)
    {
        SkillImg.sprite = img;
    }

    public void ActiveAll()
    {
        RoleImg.enabled = true;
        RoleText.enabled = true;
        ItemImg.enabled = true;
        ItemText.enabled = true;
        SkillImg.enabled = true;
        SkillText.enabled = true;
    }

    public void SetAutoHide(bool a)
    {
        isAutoHide = a;
    }

    IEnumerator AutoHide()
    {
        while (isAutoHide)
        {
            yield return 0;

            if (RoleImg.sprite != null)
                RoleText.enabled = false;
            else
                RoleText.enabled = true;

            if (ItemImg.sprite != null)
                ItemText.enabled = false;
            else
                ItemText.enabled = true;

            if (SkillImg.sprite != null)
                SkillText.enabled = false;
            else
                SkillText.enabled = true;
        }
    }
}
