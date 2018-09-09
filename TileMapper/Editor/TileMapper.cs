using UnityEditor;
using UnityEngine;

public class TileMapper : EditorWindow
{
    int tileSize = 5;
    int mapSize = 20;
    int buttonSize = 40;
    int margin = 300;
    int selectedButton = 0;
    MapData tileMapper;
    private string targetFolder = "";
    // Add menu named "My Window" to the Window menu
    [MenuItem("Window/My Window")]
    static void Init()
    {

        // Get existing open window or if none, make a new one:
        TileMapper window = (TileMapper)EditorWindow.GetWindow(typeof(TileMapper));
        window.Show();
    }

    void OnFocus()
    {
        tileMapper = FindObjectOfType<MapData>();
        tileMapper.SetTiles(mapSize * mapSize);
        SceneView.onSceneGUIDelegate -= this.OnSceneGUI;
        SceneView.onSceneGUIDelegate += this.OnSceneGUI;
    }

    void OnDestroy()
    {
        SceneView.onSceneGUIDelegate -= this.OnSceneGUI;
    }

    void OnSceneGUI(SceneView sceneView)
    {
        SceneView.lastActiveSceneView.orthographic = true;
        sceneView.LookAt(Vector3.zero, Quaternion.Euler(90, 0, 0));
        SceneView.lastActiveSceneView.Repaint();
        sceneView.size = mapSize * tileSize;
    }

    void OnGUI()
    {
        string[] guids1 = AssetDatabase.FindAssets("l:terrain");
        GameObject[] tilesModels = new GameObject[guids1.Length];

        if (GUILayout.Button("Delete", GUILayout.MaxWidth(margin - 10)))
        {
            selectedButton = -1;
        }
        for (var i = 0; i < guids1.Length; i++)
        {
            GameObject gameObject = (GameObject)AssetDatabase.LoadAssetAtPath(AssetDatabase.GUIDToAssetPath(guids1[i]), typeof(GameObject));
            tilesModels[i] = gameObject;
            if (i == selectedButton)
                GUI.color = Color.green;
            if (GUILayout.Button(gameObject.name, GUILayout.MaxWidth(margin - 10)))
            {
                selectedButton = i;
            }
            GUI.color = Color.white;
        }

        var decimals = 0;
        for (var i = 0; i < mapSize; i++)
        {
            for (var j = 0; j < mapSize; j++)
            {
                if (tileMapper.GetTiles()[i + (j * mapSize)] != null)
                    GUI.color = Color.green;

                if (GUI.Button(new Rect(i * buttonSize + margin, j * buttonSize, buttonSize, buttonSize), (i + (j * mapSize)).ToString()))
                {
                    if (selectedButton != -1)
                    {
                        GameObject clone = PrefabUtility.InstantiatePrefab(tilesModels[selectedButton] as GameObject) as GameObject;
                        tileMapper.AddTile(i + (j * mapSize), clone, new Vector3(i * tileSize, 0, -j * tileSize));
                    }
                    else
                        tileMapper.RemoveTile(i + (j * mapSize));
                }
                GUI.color = Color.white;
            }
            decimals++;
        }
    }
}