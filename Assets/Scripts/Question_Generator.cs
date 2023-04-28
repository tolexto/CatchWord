using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class Question_Generator : MonoBehaviour
{
    public TMP_Text questionText;
    public Button catchedButton;
    public TMP_InputField inputText;
    public int counter = 0;
    public int currentlevel;

    string[] questionList = new string[] { "Say my name! \n...\n You're goddamn right!", "Great powers comes with \n...\nresponsbilities", "Beni beni\n...", "and I am \n...", "-Is it terrifing?\n+...", "Sorular bitti. Baþa sarmak için tekrar bas!" };
    string[] answerList = new string[] { "heisenberg", "great", "bihterini", "iron man", "no", null };

    public void turkishCharacter()
    {
        if (inputText.text.Contains("ý"))
        {
            inputText.text = inputText.text.Substring(0, inputText.text.Length - 1) + "i";
        }//if sonu

        else if (inputText.text.Contains("þ"))
        {
            inputText.text = inputText.text.Substring(0, inputText.text.Length - 1) + "s";
        }//elseif sonu

        else if (inputText.text.Contains("ç"))
        {
            inputText.text = inputText.text.Substring(0, inputText.text.Length - 1) + "c";
        }//elseif sonu

        else if (inputText.text.Contains("ð"))
        {
            inputText.text = inputText.text.Substring(0, inputText.text.Length - 1) + "g";
        }//elseif sonu

        else if (inputText.text.Contains("ü"))
        {
            inputText.text = inputText.text.Substring(0, inputText.text.Length - 1) + "u";
        }//elseif sonu

        else if (inputText.text.Contains("ö"))
        {
            inputText.text = inputText.text.Substring(0, inputText.text.Length - 1) + "o";
        }//elseif sonu
    }

    public void ButtonPressed()
    {
        if (counter >= 5)
        {
            counter = 0;
            questionText.text = questionList[counter];
            inputText.text = "";
        }//if sonu
        else
        {
            if (inputText.text.Equals(answerList[counter]))
            {
                counter++;
                questionText.text = questionList[counter];
                inputText.text = "";

            }//if sonu
            else
            {
                inputText.text = "Wrong Answer :)";

            }//else sonu

        }//else sonu
    }//ButtonPressed() sonu
    
    public void SavePlayer(Question_Generator player) //??
    {
        SaveSystem.SavePlayer(this);
    }
    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        counter = data.currentlevel;
    }
    void Start()
    {
        questionText.text = questionList[counter];
    }//void Start sonu

    void Update()
    {
        inputText.text = inputText.text.ToLower();
        turkishCharacter();

    }//void Update() sonu
}
