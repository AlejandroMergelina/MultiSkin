using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaingColor : MonoBehaviour
{

    [SerializeField]
    private Sprite sprite;
    [SerializeField]
    private Sprite palet;

    
    private Sprite spriteFinal;

    [SerializeField]
    private SpriteRenderer render;

    private Color[,] pixelsArray;

    // Start is called before the first frame update
    void Start()
    {
        pixelsArray = new Color[(int)sprite.rect.width, (int)sprite.rect.width];
        Texture2D texture = Instantiate(render.sprite.texture);
        spriteFinal = Sprite.Create(texture, sprite.rect, Vector2.one * 0.5f);
        //Texture2D texture = new Texture2D((int)sprite.rect.width, (int)sprite.rect.height);
        //texture.SetPixels(sprite.texture.GetPixels((int)sprite.textureRect.x, (int)sprite.textureRect.y, (int)sprite.textureRect.width, (int)sprite.textureRect.height));

        //Color[] pixels = texture.GetPixels();
        ReadPalet();
        //PrintIntoSprite();

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
                //pixelsArray[i, j] = sprite.texture.GetPixel(i, j);
                spriteFinal.texture.SetPixel(i, j, currentColor /*palet.texture.GetPixel(((Color32)sprite.texture.GetPixel(i, j)).r, ((Color32)sprite.texture.GetPixel(i, j)).b)*/);

                print(/*"iteracion "+ i + "/" + j + " = " +*/ sprite.texture.GetPixel(i, j));

            }
        }
        spriteFinal.texture.Apply();
        render.sprite = spriteFinal;
    }

    private void PrintIntoSprite()
    {

        for (int i = 0; i < (int)sprite.rect.width; i++)
        {
            for (int j = 0; j < (int)sprite.rect.height; j++)
            {

                pixelsArray[i, j] = sprite.texture.GetPixel(i, j);
                spriteFinal.texture.SetPixel(i, j, sprite.texture.GetPixel(i, j));
                spriteFinal.texture.Apply();
                render.sprite = spriteFinal;
                print(/*"iteracion "+ i + "/" + j + " = " +*/ spriteFinal.texture.GetPixel(i, j));

            }
        }

    }
    
}
