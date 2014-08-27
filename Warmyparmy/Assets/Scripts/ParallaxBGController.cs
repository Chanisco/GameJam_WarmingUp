using UnityEngine;
using System.Collections;

public class ParallaxBGController : MonoBehaviour
{
    /// <summary>
    /// The background layers
    /// </summary>
    public ParallaxBG[] Layers;

    public void Start()
    {
        Vector3 baseOffset = transform.position;

        foreach (ParallaxBG bg in Layers)
        {
            // Get Objects Size
            float
                bg1Width = bg.BG1.GetComponent<SpriteRenderer>().bounds.size.x;

            bg.BG1.transform.position = AddVector3s(new Vector3[] { baseOffset, bg.BaseOffset });
            bg.BG2.transform.position = AddVector3s(new Vector3[] { baseOffset, bg.BaseOffset, new Vector3(bg1Width, 0, 0) });
        }
    }

    public void Update()
    {
        // Move All Layers
        int layers = Layers.Length;
        if (layers > 0)
        {
            for (int i = 0; i < layers; i++)
            {
                GameObject
                    BG1 = Layers[i].BG1,
                    BG2 = Layers[i].BG2;
                
                // Calculate speed for current layer
                float xSpeed = -Layers[i].MoveSpeed * Time.deltaTime;

                // Apply speed to layer
                BG1.transform.Translate(new Vector3(xSpeed, 0, 0));
                BG2.transform.Translate(new Vector3(xSpeed, 0, 0));

                // Get Objects Size
                float
                    bg1Width = BG1.GetComponent<SpriteRenderer>().bounds.size.x,
                    bg2Width = BG2.GetComponent<SpriteRenderer>().bounds.size.x;


                // Check if out of screen
                if (BG1.transform.position.x < -bg1Width)
                    BG1.transform.Translate(new Vector3(bg1Width + bg2Width, 0, 0));
                if (BG2.transform.position.x < -bg2Width)
                    BG2.transform.Translate(new Vector3(bg1Width + bg2Width, 0, 0));
            }
        }
    }

    private Vector3 AddVector3s(Vector3[] items)
    {
        float x = 0, y = 0, z = 0;
        foreach (Vector3 c in items)
        {
            x += c.x;
            y += c.y;
            z += c.z;
        }
        return new Vector3(x, y, z);
    }
}
