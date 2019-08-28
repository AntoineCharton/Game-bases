using UnityEngine;
using System.Collections.Generic;

public class ChangeMaterialShaderOnStart : MonoBehaviour
{
    public Shader shader;

    public List<ShaderSwitcher> ShaderSwitcher;

    // Use this for initialization
    void Start()
    {
        SetToStart();

    }

    public void SetToStart()
    {
        foreach (var shaderSwitcher in ShaderSwitcher)
        {
            shaderSwitcher.Initialize(shader);
        }

    }

    public void ResetShader()
    {
        foreach (var shaderSwitcher in ShaderSwitcher)
        {
            shaderSwitcher.ResetMaterial();
        }
    }

    void OnDestroy()
    {
        ResetShader();
        
    }
}
