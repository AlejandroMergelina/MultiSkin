using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaingColor : MonoBehaviour
{
    [SerializeField]
    private Sprite sprite;

    private Color[,] pixelsArray;

    // Start is called before the first frame update
    void Start()
    {
        pixelsArray = new Color[(int)sprite.rect.width, (int)sprite.rect.width];

        //Texture2D texture = new Texture2D((int)sprite.rect.width, (int)sprite.rect.height);
        //texture.SetPixels(sprite.texture.GetPixels((int)sprite.textureRect.x, (int)sprite.textureRect.y, (int)sprite.textureRect.width, (int)sprite.textureRect.height));

        //Color[] pixels = texture.GetPixels();
        for (int i = 0; i < (int)sprite.rect.width; i++)
        {
            for (int j = 0; j < (int)sprite.rect.height; j++)
            {

                pixelsArray[i,j] = sprite.texture.GetPixel(i+1, j+1);
                print(sprite.texture.GetPixel(i + 1, j + 1));

            }
        }
       

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
