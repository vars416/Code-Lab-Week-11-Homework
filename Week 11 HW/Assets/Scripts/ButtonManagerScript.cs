using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManagerScript : MonoBehaviour
{
    public GameObject Question;
    public GameObject YesButton;
    public GameObject NoButton;
    public GameObject nameField;
    public GameObject submit;
    public GameObject HelloText;
    public GameObject JokeOption1;
    public GameObject JokeOption2;
    public GameObject continue1;
    public GameObject continue2;
    public GameObject Joke_01_1;
    public GameObject Joke_01_2;
    public GameObject Joke_02_1;
    public GameObject Joke_02_2;
    public GameObject DrownButton;
    //Turns off the nameField and submit button
    //Turns on the leftButton and rightButton

    public void AskIfTheyWantToHearJoke() //asks players if they want to hear a joke
    {
        YesButton.SetActive(true);
        NoButton.SetActive(true);
        submit.SetActive(false);
        nameField.SetActive(false);
    }
    public void SayYesToJoke() //gives Koala and Tekken option
    {
        Question.SetActive(true);
        YesButton.SetActive(false);
        NoButton.SetActive(false);
        HelloText.SetActive(false);
        JokeOption1.SetActive(true);
        JokeOption2.SetActive(true);
    }

    public void Joke_01() //Koala Joke part 1
    {
        Question.SetActive(false);
        JokeOption1.SetActive(false);
        JokeOption2.SetActive(false);
        Joke_01_1.SetActive(true);
        continue1.SetActive(true);
    }

    public void Joke_01_contd() //Koala Joke part 2
    {
        Joke_01_1.SetActive(false);
        continue1.SetActive(false);
        Joke_01_2.SetActive(true);
        DrownButton.SetActive(true);
    }

    public void Joke_02() //Tekken Joke part 1
    {
        Question.SetActive(false);
        JokeOption1.SetActive(false);
        JokeOption2.SetActive(false);
        Joke_02_1.SetActive(true);
        continue2.SetActive(true);
    }

    public void Joke_02_contd() //Tekken Joke part 2
    {
        Joke_02_1.SetActive(false);
        continue2.SetActive(false);
        Joke_02_2.SetActive(true);
        DrownButton.SetActive(true);
    }
}
