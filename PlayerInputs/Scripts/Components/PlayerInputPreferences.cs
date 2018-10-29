using UnityEngine;

public class PlayerInputPreferences {
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
    private const string fourthActionKey = "fourthActionKey";
    public string fourthAction;
    public enum KeyTypes { Action, Attack, ThirdAction, FourthAction, Keyboard }

    public PlayerInputPreferences () {
        LoadPlayerPrefs ();
    }

    public void LoadPlayerPrefs () {
        forward = PlayerPrefs.GetString (forwardKey, "w");
        backward = PlayerPrefs.GetString (backwardKey, "s");
        left = PlayerPrefs.GetString (leftKey, "a");
        right = PlayerPrefs.GetString (rightKey, "d");
        action = PlayerPrefs.GetString (actionKey, "f");
        secondAction = PlayerPrefs.GetString (secondActionKey, "e");
        thirdAction = PlayerPrefs.GetString (thirdActionKey, "c");
        fourthAction = PlayerPrefs.GetString (fourthActionKey, "q");
    }

    public void SetQwerty () {
        PlayerPrefs.SetString (forwardKey, "w");
        PlayerPrefs.SetString (backwardKey, "s");
        PlayerPrefs.SetString (leftKey, "a");
        PlayerPrefs.SetString (rightKey, "d");
        PlayerPrefs.SetString (actionKey, "f");
        PlayerPrefs.SetString (secondActionKey, "e");
        PlayerPrefs.SetString (thirdActionKey, "c");
        PlayerPrefs.SetString (fourthActionKey, "q");

        LoadPlayerPrefs ();
    }

    public void SetAzerty () {
        PlayerPrefs.SetString (forwardKey, "z");
        PlayerPrefs.SetString (backwardKey, "s");
        PlayerPrefs.SetString (leftKey, "q");
        PlayerPrefs.SetString (rightKey, "d");
        PlayerPrefs.SetString (actionKey, "f");
        PlayerPrefs.SetString (secondActionKey, "e");
        PlayerPrefs.SetString (thirdActionKey, "c");
        PlayerPrefs.SetString (fourthActionKey, "a");
        LoadPlayerPrefs ();
    }

    public string GetForward () {
        return forward;
    }

    public string GetBackward () {
        return backward;
    }

    public string GetLeft () {
        return left;
    }

    public string GetRight () {
        return right;
    }

    public string GetAction () {
        return action;
    }

    public string GetSecondAction () {
        return secondAction;
    }

    public string GetThirdAction () {
        return thirdAction;
    }
}