using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ClaimPanelHandler : MonoBehaviour
{
    public GameObject claimPanel;
    // Start is called before the first frame update
    void Start()
    {
        claimPanel.transform.localScale = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnActivation() { 
        claimPanel.SetActive(true);
        claimPanel.transform.DOScale(Vector3.one, 0.35f).SetEase(Ease.OutBack);
    }
    public void OnDeactivation()
    {
        claimPanel.transform.DOScale(Vector3.zero, 0.35f).SetEase(Ease.InBack).OnComplete(() =>
        {

            claimPanel.SetActive(false);
        });
    }
}
