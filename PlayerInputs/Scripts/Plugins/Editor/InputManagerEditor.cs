using UnityEditor;
using UnityEngine;
using System.Collections.Generic;
using PlayerInputs;

[CustomEditor(typeof(PlayerInputManager))]
public class InputManagerEditor : Editor
{
    int numberOfReceivers;
    public override void OnInspectorGUI()
    {
        PlayerInputManager inputManager = (PlayerInputManager)target;
        if (inputManager.Receivers == null)
            inputManager.Receivers = new List<InputObject>();

        var inheritedObjects = ReflectionUtils.GetEnumerableOfType<InputBase>(null);
        string[] options = inheritedObjects;
        PlayerInputManager myTarget = (PlayerInputManager)target;

        InputObject elementToRemove = null;
        InputObject elementToAdd = null;
        var index = 0;
        var catchedIndex = 0;
        foreach (var receiver in inputManager.Receivers)
        {
            var labelText = "No gameobject selected";
            if (receiver.ControllableObject != null)
                labelText = receiver.ControllableObject.name;

            GUILayout.Label(labelText);
            receiver.ControllableObject = EditorGUILayout.ObjectField(receiver.ControllableObject, typeof(GameObject), true) as GameObject;

            int selected = 0;
            var isOneSelected = false;

            for (var i = 0; i < inheritedObjects.Length; i++)
            {
                selected = i;
                if (receiver.InputType == inheritedObjects[i])
                {
                    receiver.InputType = inheritedObjects[i];
                    isOneSelected = true;
                    break;
                }
            }
            selected = EditorGUILayout.Popup("Input type", selected, options);
            receiver.InputType = inheritedObjects[selected];

            if (!isOneSelected)
            {
                receiver.InputType = inheritedObjects[0];
            }

            GUILayout.BeginHorizontal();
            if (GUILayout.Button("+", GUILayout.Width(25)))
            {
                catchedIndex = index + 1;
                elementToAdd = new InputObject();

            }

            if (GUILayout.Button("-", GUILayout.Width(25)))
            {
                elementToRemove = receiver;
            }
            receiver.id = GUILayout.TextField(receiver.id, 25);
            receiver.isEnabled = GUILayout.Toggle(receiver.isEnabled, "is Enabled");
            GUILayout.EndHorizontal();
            GUILayout.Label("_________________________________________________________________________________________________________________________________________________________________________");
            index++;
        }

        if (elementToRemove != null)
            inputManager.Receivers.Remove(elementToRemove);

        if (elementToAdd != null)
            inputManager.Receivers.Insert(catchedIndex, elementToAdd);

        if (index < 1)
            if (GUILayout.Button("+"))
            {
                inputManager.Receivers.Add(new InputObject());
            }
    }
}