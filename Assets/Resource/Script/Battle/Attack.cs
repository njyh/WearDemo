using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Attack : MonoBehaviour
{
    public bool attack = false;
    public Text DebugInfo;
    public Texture2D DefCur;

    public void setAttack(bool b)
    {
        attack = b;
    }
    
    public void SetCursor(Texture2D texture)
    {
        Cursor.SetCursor(texture, Vector2.zero, CursorMode.Auto);
        
        
    }
    public void dt(string text)
    {
        DebugInfo.text = text;
    }
    public void OnAttack(string name)
    {
        if (attack)
        {
            dt("你成功的向" + name + "造成了？点伤害");
            
            SetCursor(DefCur);
            attack = false;
        }
        else
        {
            dt("不在攻击模式，请选择角色再发动攻击");
        }
    }
}
