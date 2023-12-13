using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaingColor : MonoBehaviour
{

    [SerializeField]
    private Sprite sprite;
    [SerializeField]
    private Sprite palet;
    [SerializeField]
    private Sprite canvas;


    void Start()
    {
        ReadPalet();
    }

    private void ReadPalet()
    {

        for (int i = 0; i < (int)sprite.rect.width; i++)
        {
            for (int j = 0; j < (int)sprite.rect.height; j++)
            {
                Color currentColor;
                currentColor.r = palet.texture.GetPixel(((Color32)sprite.texture.GetPixel(i, j)).r, ((Color32)sprite.texture.GetPixel(i, j)).b).r;
                currentColor.g = palet.texture.GetPixel(((Color32)sprite.texture.GetPixel(i, j)).r, ((Color32)sprite.texture.GetPixel(i, j)).b).g;
                currentColor.b = palet.texture.GetPixel(((Color32)sprite.texture.GetPixel(i, j)).r, ((Color32)sprite.texture.GetPixel(i, j)).b).b;
                currentColor.a = sprite.texture.GetPixel(i, j).a;
                canvas.texture.SetPixel(i, j, currentColor);

            }
        }

        canvas.texture.Apply();
    }
    
}
