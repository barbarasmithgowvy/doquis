using UnityEngine;
using UnityEditor;

public class TextureTypeCheck : MonoBehaviour
{
    public TextureImporterType textureType;

    void Start()
    {
        if (textureType == TextureImporterType.Sprite)
        {
            Debug.Log("Texture is imported as a sprite.");
            // Additional logic for sprite handling
        }
    }
}
