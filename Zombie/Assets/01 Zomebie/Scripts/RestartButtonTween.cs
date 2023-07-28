using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class RestartButtonTween : MonoBehaviour, IPointerEnterHandler
{
        Tween shakeAni = default;
    public void OnPointerEnter(PointerEventData eventData) 
    {
        Debug.Log("마우스 올려두었다.");

        if (shakeAni == null || shakeAni == default)
        {
        shakeAni = transform.DOShakeScale(0.5f, 1, 10, 90, true, ShakeRandomnessMode.Full).SetAutoKill();
            shakeAni.onKill += () => DisposeShake();
            return;
        }
     
    }

    // Twin이 Kill 될 때 shakeAni 변수를 비워주는 함수
    private void DisposeShake()
    {
        shakeAni = default;
    }

}
