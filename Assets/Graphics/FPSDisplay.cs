using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FPSDisplay : MonoBehaviour
{
    public int avgFrameRate;
    public Text display_Text;
    bool updateCheck = true;

    public void Update()
    {
        updateCheck = !updateCheck;
        if (!updateCheck)
            return;

        float current = 0;
        current = (int)(1f / Time.unscaledDeltaTime);
        avgFrameRate = (int)current;
        display_Text.text = "FPS: " + avgFrameRate.ToString();
    }
}