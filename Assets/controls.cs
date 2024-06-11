using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controls : MonoBehaviour
{
    public float horizontal;
    public float speedX;
    public float SpeedY;
    private Rigidbody2D _comprigidbody2D;
    public float vertical;
    public GameObject bulletPrefab;
    public AudioSource Bala_sound;
    private void Awake()
    {
        _comprigidbody2D = GetComponent<Rigidbody2D>();
    } 
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        _comprigidbody2D.velocity = new Vector2(speedX * horizontal, SpeedY * vertical);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") == true)
        {
            Instantiate(bulletPrefab, transform.position, transform.rotation);
            Bala_sound.Play();
        }
    }
}
