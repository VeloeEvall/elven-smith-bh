using System.Collections.Generic;
using UnityEditor;

[CustomEditor(typeof(Localization))]
public class LocalizationEditor : Editor
{
    private List<string> _choices;

    private void OnEnable()
    {
        _choices = LocalizationManager.GetReferences();
    }

    private int _choiceIndex = 0;

    public override void OnInspectorGUI()
    {
        // Draw the default inspector
        DrawDefaultInspector();
        _choiceIndex = EditorGUILayout.Popup("Reference name: ", _choiceIndex, _choices.ToArray(), EditorStyles.popup);
        var lc = target as Localization;
        // Update the selected choice in the underlying object
        lc.ReferenceName = _choices[_choiceIndex];
        // Save the changes back to the object
        EditorUtility.SetDirty(target);
    }
}