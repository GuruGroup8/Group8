using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public Material bgMaterial;
    public float scrollSpeed = 0.2f;
    float Offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Offset += Time.deltaTime * scrollSpeed;
        bgMaterial.mainTextureOffset = new Vector2(0, Offset);
    }
}
