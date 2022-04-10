using UnityEngine;

public class SwitchPrefab : MonoBehaviour
{
    public GameObject currentPrefab;
    public GameObject nextPrefab;

    public void switchToAnotherPrefab()
    {
        currentPrefab.SetActive(false);
        nextPrefab.SetActive(true);
    }
}