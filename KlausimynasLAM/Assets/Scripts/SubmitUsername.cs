using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubmitUsername : MonoBehaviour
{
    public InputField TextBox;
    public Text correctString;
    public Text timespan;

    public GameObject current;
    public GameObject next;

    public void ClickSaveButton()
    {

        string resultsFilePath = Application.streamingAssetsPath + "/results.csv";
        if (TextBox.text.Length == 0)
        {
            PlayerPrefs.SetString("username", "Anonimas");
        }
        else
        {
            PlayerPrefs.SetString("username", TextBox.text);
        }
        
        Debug.Log("Your name is " + PlayerPrefs.GetString("username"));
        GetComponent<GameController>().WritePerson(resultsFilePath, PlayerPrefs.GetString("username"));
        GetComponent<GameController>().SetResults(correctString, timespan);
        GetComponent<Leaderboard>().SetResults();
        SwitchPrefabs(current, next);
    }

    public void SwitchPrefabs(GameObject current, GameObject next)
    {
        current.SetActive(false);
        next.SetActive(true);
    }
}
