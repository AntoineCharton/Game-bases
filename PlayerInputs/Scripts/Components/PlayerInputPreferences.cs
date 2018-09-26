using UnityEngine;


public class PlayerInputPreferences
{
    public string forward;
    private const string forwardKey = "forwardKey";
    public string backward;
    private const string backwardKey = "backwarddKey";
    public string left;
    private const string leftKey = "leftKey";
    public string right;
    private const string rightKey = "righttKey";
    public string action;
    private const string actionKey = "actionKey";
    public string secondAction;
    private const string secondActionKey = "secondActionKey";
    public string thirdAction;
    private const string thirdActionKey = "thridActionKey";

    public PlayerInputPreferences()
    {
        forward = PlayerPrefs.GetString(forwardKey, "w");
        backward = PlayerPrefs.GetString(backwardKey, "s");
        left = PlayerPrefs.GetString(leftKey, "a");
        right = PlayerPrefs.GetString(rightKey, "d");
        action = PlayerPrefs.GetString(actionKey, "f");
        secondAction = PlayerPrefs.GetString(secondActionKey, "e");
        thirdAction = PlayerPrefs.GetString(thirdActionKey, "c");
    }
}
