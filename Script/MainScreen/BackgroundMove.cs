using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    private new Renderer renderer;

    public float speed;
    public float offset;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        offset = Time.time * speed;
        renderer.material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
    }
}
