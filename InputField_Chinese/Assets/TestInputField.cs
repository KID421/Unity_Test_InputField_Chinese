using UnityEngine;
using UnityEngine.UI;

public class TestInputField : MonoBehaviour
{
    public Text result;

    public void CheckInput(string input)
    {
        if (input == "紅水")
        {
            result.text = "恢復血量";
        }
        else if (input == "藍水")
        {
            result.text = "恢復魔力";
        }
    }
}
