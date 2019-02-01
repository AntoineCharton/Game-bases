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
    private const string thirdActionKey = "thridActionKey";
    public string thirdAction;
    private const string fourthActionKey = "fourthActionKey";
    public string fourthAction;
    private const string fifthActionKey = "fifthActionKey";
    public string fifthAction;
    private const string sixthActionKey = "sixthActionKey";
    public string sixthAction;
    private const string seventhActionKey = "seventhActionKey";
    public string seventhAction;
    public enum KeyTypes { Action, Attack, ThirdAction, FourthAction, Keyboard }

    public PlayerInputPreferences () {
#if UNITY_EDITOR
        PlayerPrefs.DeleteAll();
#endif
        LoadPlayerPrefs ();
    }

    public void LoadPlayerPrefs () {
        forward = PlayerPrefs.GetString (forwardKey, "w");
        backward = PlayerPrefs.GetString (backwardKey, "s");
        left = PlayerPrefs.GetString (leftKey, "a");
        right = PlayerPrefs.GetString (rightKey, "d");
        action = PlayerPrefs.GetString (actionKey, "f");
        secondAction = PlayerPrefs.GetString (secondActionKey, "z");
        thirdAction = PlayerPrefs.GetString (thirdActionKey, "c");
        fourthAction = PlayerPrefs.GetString (fourthActionKey, "space");
        fifthAction = PlayerPrefs.GetString(fifthActionKey, "escape");
        sixthAction = PlayerPrefs.GetString(sixthActionKey, "q");
        seventhAction = PlayerPrefs.GetString(seventhActionKey, "e");
    }

    public void SetQwerty () {
        PlayerPrefs.SetString (forwardKey, "w");
        PlayerPrefs.SetString (backwardKey, "s");
        PlayerPrefs.SetString (leftKey, "a");
        PlayerPrefs.SetString (rightKey, "d");
        PlayerPrefs.SetString (actionKey, "f");
        PlayerPrefs.SetString (secondActionKey, "z");
        PlayerPrefs.SetString (thirdActionKey, "c");
        PlayerPrefs.SetString (fourthActionKey, "space");
        PlayerPrefs.SetString(fifthActionKey, "escape");
        PlayerPrefs.SetString(sixthActionKey, "q");
        PlayerPrefs.SetString(seventhActionKey, "e");
        LoadPlayerPrefs ();
    }

    public void SetAzerty () {
        PlayerPrefs.SetString (forwardKey, "z");
        PlayerPrefs.SetString (backwardKey, "s");
        PlayerPrefs.SetString (leftKey, "q");
        PlayerPrefs.SetString (rightKey, "d");
        PlayerPrefs.SetString (actionKey, "f");
        PlayerPrefs.SetString (secondActionKey, "w");
        PlayerPrefs.SetString (thirdActionKey, "c");
        PlayerPrefs.SetString (fourthActionKey, "space");
        PlayerPrefs.SetString(fifthActionKey, "escape");
        PlayerPrefs.SetString(sixthActionKey, "a");
        PlayerPrefs.SetString(seventhActionKey, "e");
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