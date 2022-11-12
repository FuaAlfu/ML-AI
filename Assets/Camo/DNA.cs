using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2022.11.12
/// </summary>

public class DNA : MonoBehaviour
{
    //gene for colour
    public float r;
    public float g;
    public float b;

    public float timeToDie = 0;
    bool isDead = false;
    SpriteRenderer spriteRenderer;
    Collider2D collider2;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        collider2 = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        isDead = true;
       // timeToDie = PopulationManager.elapsed;
        Debug.Log("Dead at: " + timeToDie);
        spriteRenderer.enabled = false;
        collider2.enabled = false;
    }
}
