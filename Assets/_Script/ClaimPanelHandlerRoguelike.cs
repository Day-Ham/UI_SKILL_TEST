using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClaimPanelHandlerRoguelike : MonoBehaviour
{
    public float delay= .25f;
    public AudioSource src;
    public AudioSource loop;
    public AudioSource closing;
    public GameObject claimPanel;
    public GameObject RegularTier;
    public ParticleSystem RevealVFX;
    void Start()
    {
        RegularTier.SetActive(false);
        claimPanel.transform.localScale = Vector3.zero;
    }

    public void OnActivation()
    {
        RevealVFX.gameObject.SetActive(true);
        RevealVFX.Play();
        claimPanel.SetActive(true);
        PlayClaimSound();
        claimPanel.transform.DOScale(Vector3.one, 0.35f).SetEase(Ease.OutBack);
    }
    public void OnDeactivation()
    {
        closing.Play();
        loop.Stop();
        RevealVFX.gameObject.SetActive(false);
        claimPanel.transform.DOScale(Vector3.zero, 0.35f).SetEase(Ease.InBack).OnComplete(() =>
        {

            claimPanel.SetActive(false);
            RegularTier.SetActive(false);
        });
    }
    public void PlayClaimSound()
    {
        src.Play();
        StartCoroutine(WaitForAudioToFinish());
    }

    IEnumerator WaitForAudioToFinish()
    {
        yield return new WaitForSeconds(src.clip.length-delay);
        // Code to execute after audio finishes
        RegularTier.SetActive(true);
        loop.Play();
    }
}
