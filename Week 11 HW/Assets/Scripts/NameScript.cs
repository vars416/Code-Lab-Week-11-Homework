using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NameScript : MonoBehaviour
{
    public Text nameText;
    public Text title;

    public string welcomeText;
    public string replaceWithName;

    public void SubmitName()
    {
        print(nameText.text); //print submitted name

        string[] names = nameText.text.Split(' '); //access the name written

        title.text = welcomeText.Replace(replaceWithName, names[0]); //replace with the name written by the player
    }
}
