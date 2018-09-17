using UnityEngine;

public class ChangeMaterialShaderOnStart : MonoBehaviour
{
    public Shader shader;
    public Material Material;
    private Shader previousShader;
    // Use this for initialization
    void Start()
    {
        previousShader = Material.shader;
        Material.shader = shader;
    }

    void OnDestroy()
    {
        if (previousShader != null)
            Material.shader = previousShader;
    }
}
