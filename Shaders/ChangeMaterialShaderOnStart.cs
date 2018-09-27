using UnityEngine;
using System.Collections.Generic;

public class ChangeMaterialShaderOnStart : MonoBehaviour
{
    public Shader shader;

    public List<ShaderSwitcher> ShaderSwitcher;

    // Use this for initialization
    void Start()
    {

        foreach(var shaderSwitcher in ShaderSwitcher) {
            shaderSwitcher.Initialize(shader);
        }
       
    }

    void OnDestroy()
    {
        foreach(var shaderSwitcher in ShaderSwitcher) {
            shaderSwitcher.ResetMaterial();
        }
        
    }
}
