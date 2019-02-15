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
    public string fireInput;
    private const string fireKey = "secondActionKey";
    private const string firstSecondaryInputKey = "thridActionKey";
    public string firstSecondaryInput;
    private const string jumpKey = "fourthActionKey";
    public string jumpInput;
    private const string secondSecondaryKey = "fifthActionKey";
    public string secondSecondaryInput;
    private const string thirdSecondaryKey = "sixthActionKey";
    public string thirdSecondaryInput;
    private const string fourthSecondaryKey = "seventhActionKey";
    public string fourthSecondaryInput;
    private const string cancelKey = "cancelKey";
    public string cancelInput;
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
        fireInput = PlayerPrefs.GetString (fireKey, "z");
        firstSecondaryInput = PlayerPrefs.GetString (firstSecondaryInputKey, "c");
        secondSecondaryInput = PlayerPrefs.GetString(secondSecondaryKey, "escape");
        thirdSecondaryInput = PlayerPrefs.GetString(thirdSecondaryKey, "q");
        fourthSecondaryInput = PlayerPrefs.GetString(fourthSecondaryKey, "e");
        jumpInput = PlayerPrefs.GetString(jumpKey, "space");
        cancelInput = PlayerPrefs.GetString(cancelKey, "escape");
    }

    public void SetQwerty () {
        PlayerPrefs.SetString (forwardKey, "w");
        PlayerPrefs.SetString (backwardKey, "s");
        PlayerPrefs.SetString (leftKey, "a");
        PlayerPrefs.SetString (rightKey, "d");
        PlayerPrefs.SetString (actionKey, "f");
        PlayerPrefs.SetString (fireKey, "z");
        PlayerPrefs.SetString (firstSecondaryInputKey, "c");
        PlayerPrefs.SetString (jumpKey, "space");
        PlayerPrefs.SetString(secondSecondaryKey, "escape");
        PlayerPrefs.SetString(thirdSecondaryKey, "q");
        PlayerPrefs.SetString(fourthSecondaryKey, "e");
        PlayerPrefs.SetString(cancelKey, "escape");
        LoadPlayerPrefs ();
    }

    public void SetAzerty () {
        PlayerPrefs.SetString (forwardKey, "z");
        PlayerPrefs.SetString (backwardKey, "s");
        PlayerPrefs.SetString (leftKey, "q");
        PlayerPrefs.SetString (rightKey, "d");
        PlayerPrefs.SetString (actionKey, "f");
        PlayerPrefs.SetString (fireKey, "w");
        PlayerPrefs.SetString (firstSecondaryInputKey, "c");
        PlayerPrefs.SetString (jumpKey, "space");
        PlayerPrefs.SetString(secondSecondaryKey, "escape");
        PlayerPrefs.SetString(thirdSecondaryKey, "a");
        PlayerPrefs.SetString(fourthSecondaryKey, "e");
        PlayerPrefs.SetString(cancelKey, "escape");
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
        return fireInput;
    }

    public string GetThirdAction () {
        return firstSecondaryInput;
    }
}