using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomizer : MonoBehaviour
{
    public ClaimPanelHandlerRoguelike[] claimPanels;

    public void OpenTreasureChest()
    {
        claimPanels[ Random.Range(0, claimPanels.Length)].OnActivation();

    }

}
