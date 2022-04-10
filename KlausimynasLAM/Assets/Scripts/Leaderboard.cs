using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

public class Leaderboard : MonoBehaviour
{
    int index = 0;
    public GameObject[] options;

    string resultsFilePath = "Assets/Data/results.csv";

    List<string> personName = new List<string>();
    List<string> correctQuestions = new List<string>();
    List<string> time = new List<string>();

    //public Text personNameText;

    //List<Person> personList = readPersonData(sortedResultsFilePath);


    void Start()
    {
        //List<Person> personList = readPersonData(resultsFilePath);
        setAnswers();
    }

    void setAnswers()
    {
        List<Person> personList = readPersonData(resultsFilePath);

        var peopleSorted = personList
                .OrderByDescending(person => person.correcqs)
                .ThenBy(person => person.time)
                .ThenBy(person => person.name)
                .Take(6)
                .ToList();

        for (int i = 0; i < options.Length; i++)
        {

            options[index].transform.GetChild(1).GetComponent<Text>().text = peopleSorted[index].getName();
            options[index].transform.GetChild(2).GetComponent<Text>().text = peopleSorted[index].getCorrectAndAll();
            options[index].transform.GetChild(4).GetComponent<Text>().text = peopleSorted[index].getTime();
            index++;
        }


    }

    public List<Person> readPersonData(string fileName)
    {
        List<Person> personList = new List<Person>();
        string[] lines = File.ReadAllLines(fileName, Encoding.GetEncoding(1257));
        foreach (var line in lines)
        {
            string[] parts = line.Trim().Split(',');
            string name = parts[0];
            int correctqs = int.Parse(parts[1]);
            int allqs = int.Parse(parts[2]);
            string time = parts[3];

            Person person = new Person(name, correctqs, allqs, time);
            personList.Add(person);
        }
        return personList;
    }
}