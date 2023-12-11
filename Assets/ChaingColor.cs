using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaingColor : MonoBehaviour
{

    private Color[,] pixelsArray;

    [SerializeField] private Texture2D texture;

    // Start is called before the first frame update
    void Start()
    {
        Sprite[] sprites = Resources.LoadAll<Sprite>(texture.name);
        //sprites[0].rect.width
        //sprites[0].pivot
        pixelsArray = new Color[(int)sprites[0].rect.width, (int)sprites[0].rect.height];
        Debug.Log((int)sprites[0].pivot.x);
        ////Texture2D texture = new Texture2D((int)sprite.rect.width, (int)sprite.rect.height);
        ////texture.SetPixels(sprite.texture.GetPixels((int)sprite.textureRect.x, (int)sprite.textureRect.y, (int)sprite.textureRect.width, (int)sprite.textureRect.height));

        ////Color[] pixels = texture.GetPixels();
        int spriteWidth = (int)sprites[0].rect.width;

        for (int i = 0; i < spriteWidth; i++)
        {
            for (int j = 0; j < (int)sprites[0].rect.height; j++)
            {

                pixelsArray[i, j] = sprites[0].texture.GetPixel(i + (int)sprites[0].pivot.x, j + (int)sprites[0].pivot.y);
                print(pixelsArray[i, j]);

            }
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
