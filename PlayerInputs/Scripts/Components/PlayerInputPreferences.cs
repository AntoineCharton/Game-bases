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
    private const string fifthSecondarykey = "heightsActionKey";
    public string fifthSecondaryInput;
    private const string cancelKey = "cancelKey";
    public string cancelInput;
    public enum KeyTypes { Action, Attack, Aim, Jump, FirstSecondaryAction,SecondSecondaryAction, ThirdSecondaryAction, FourthSecondaryAction, FifthSecondaryAction}

    public PlayerInputPreferences () {
        LoadPlayerPrefs ();
    }

    public void LoadPlayerPrefs () {
        forward = PlayerPrefs.GetString (forwardKey, "w");
        backward = PlayerPrefs.GetString (backwardKey, "s");
        left = PlayerPrefs.GetString (leftKey, "a");
        right = PlayerPrefs.GetString (rightKey, "d");
        action = PlayerPrefs.GetString (actionKey, "f");
        fireInput = PlayerPrefs.GetString (fireKey, "z");
        firstSecondaryInput = PlayerPrefs.GetString (firstSecondaryInputKey, "ctrl");
        secondSecondaryInput = PlayerPrefs.GetString(secondSecondaryKey, "escape");
        thirdSecondaryInput = PlayerPrefs.GetString(thirdSecondaryKey, "q");
        fourthSecondaryInput = PlayerPrefs.GetString(fourthSecondaryKey, "e");
        fifthSecondaryInput = PlayerPrefs.GetString(fifthSecondarykey, "x");
        jumpInput = PlayerPrefs.GetString(jumpKey, "space");
        cancelInput = PlayerPrefs.GetString(cancelKey, "escape");
    }

    public void SetQwerty () {
        PlayerPrefs.SetString (forwardKey, "w");
        PlayerPrefs.SetString (backwardKey, "s");
        PlayerPrefs.SetString (leftKey, "a");
        PlayerPrefs.SetString (rightKey, "d");
        PlayerPrefs.SetString (actionKey, "f");
        PlayerPrefs.SetString (fireKey, "g");
        PlayerPrefs.SetString (firstSecondaryInputKey, "ctrl");
        PlayerPrefs.SetString (jumpKey, "space");
        PlayerPrefs.SetString(secondSecondaryKey, "escape");
        PlayerPrefs.SetString(thirdSecondaryKey, "q");
        PlayerPrefs.SetString(fourthSecondaryKey, "e");
        PlayerPrefs.SetString(fifthSecondarykey, "x");
        PlayerPrefs.SetString(cancelKey, "escape");
        LoadPlayerPrefs ();
    }

    public void SetAzerty () {
        PlayerPrefs.SetString (forwardKey, "z");
        PlayerPrefs.SetString (backwardKey, "s");
        PlayerPrefs.SetString (leftKey, "q");
        PlayerPrefs.SetString (rightKey, "d");
        PlayerPrefs.SetString (actionKey, "f");
        PlayerPrefs.SetString (fireKey, "g");
        PlayerPrefs.SetString (firstSecondaryInputKey, "shift");
        PlayerPrefs.SetString (jumpKey, "space");
        PlayerPrefs.SetString(secondSecondaryKey, "escape");
        PlayerPrefs.SetString(thirdSecondaryKey, "a");
        PlayerPrefs.SetString(fourthSecondaryKey, "e");
        PlayerPrefs.SetString(fifthSecondarykey, "x");
        PlayerPrefs.SetString(cancelKey, "escape");
        LoadPlayerPrefs ();
    }

    public void SetFifthSecondary(string key)
    {
        if (key != "")
            PlayerPrefs.SetString(fifthSecondarykey, key);
    }

    public void SetFourthSecondary(string key)
    {
        if(key != "")
            PlayerPrefs.SetString(fourthSecondaryKey, key);
    }

    public void SetThirdSecondary(string key)
    {
        if (key != "")
            PlayerPrefs.SetString(thirdSecondaryKey, key);
    }

    public void SetSecondSecondary(string key)
    {
        if (key != "")
            PlayerPrefs.SetString(secondSecondaryKey, key);
    }

    public void SetFirstSecondary(string key)
    {
        if (key != "")
            PlayerPrefs.SetString(firstSecondaryInputKey, key);
    }

    public void SetForward(string key)
    {
        if (key != "")
            PlayerPrefs.SetString(forwardKey, key);
    }

    public void SetBackward(string key)
    {
        if (key != "")
            PlayerPrefs.SetString(backwardKey, key);
    }

    public void SetLeft(string key)
    {
        if (key != "")
            PlayerPrefs.SetString(leftKey, key);
    }

    public void SetRight(string key)
    {
        if (key != "")
            PlayerPrefs.SetString(rightKey, key);
    }

    public void SetAction(string key)
    {
        if (key != "")
            PlayerPrefs.SetString(actionKey, key);
    }

    public void SetSecondAction(string key)
    {
        if (key != "")
            PlayerPrefs.SetString(secondSecondaryKey, key);
    }

    public void SetThirdAction(string key)
    {
        if (key != "")
            PlayerPrefs.SetString(thirdSecondaryKey, key);
    }

    public string GetFifthSecondary()
    {
        return fifthSecondaryInput;
    }

    public string GetFourthSecondary()
    {
        return fourthSecondaryInput;
    }

    public string GetThirdSecondary()
    {
        return thirdSecondaryInput;
    }

    public string GetSecondSecondary()
    {
        return secondSecondaryInput;
    }

    public string GetFirstSecondary()
    {
        return firstSecondaryInput;
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