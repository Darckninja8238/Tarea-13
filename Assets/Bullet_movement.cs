using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Transform _comTransform;
    private SpriteRenderer _comSpriteRenderer;
    public float speed;
    public float yDirection;
    void Awake()
    {
        _comTransform = GetComponent<Transform>();
        _comSpriteRenderer = GetComponent<SpriteRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _comTransform.position = new Vector2(0, _comTransform.position.y + speed * yDirection * Time.deltaTime);
    }
}
