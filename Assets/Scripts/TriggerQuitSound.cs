using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TriggerQuitSound : MonoBehaviour, ISelectHandler , IPointerEnterHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        print("entered");
        AudioManager.instance.Play("ButtonSelect");
    }

    public void OnSelect(BaseEventData eventData)
    {
        print("selected");
        AudioManager.instance.Play("QuitMenu");
    }
}
