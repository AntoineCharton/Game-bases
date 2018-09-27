using System;
using UnityEngine;

[System.Serializable]
public class ShaderSwitcher
{
    public Material Material;
    private Shader previousShader;

    public void Initialize(Shader shader)
    {
        previousShader = Material.shader;
        Material.shader = shader;
    }

    public void ResetMaterial()
    {
        if (previousShader != null)
            Material.shader = previousShader;
    }
}