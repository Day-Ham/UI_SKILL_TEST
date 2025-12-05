using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PulsingTween : MonoBehaviour
{
    public float original = 1.2f;
    public float max = 1.2f;
    // Start is called before the first frame update
    void Start()
    {

        transform.DOScale(max, 1f).SetEase(Ease.InOutSine).OnComplete(() => {
            {
                transform.DOScale(original, 1f).SetEase(Ease.InOutSine).OnComplete(() => {
                    Start();
                });
            } });
        // StartCoroutine(Pulse());
    }

   
}
