using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBrush : MonoBehaviour
{
    public int speed;
    public int speedrotate;
    private Vector3 mousePosition;
    public float moveSpeed = 0.1f;
    public bool follow;
    public GameObject[] sprites;
    public GameObject current;
    public SpriteManager spriteMan;


    // Start is called before the first frame update
    void Start()
    {
        follow = true;
        gameObject.transform.localScale = new Vector3(1, 1, 1);
        current = Instantiate(sprites[Random.Range(0, sprites.Length)]);
        current.GetComponent<SpriteRenderer>().color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        spriteMan.spigs.Add(current);
    }

    void selectcurrent()
    {
        current = Instantiate(sprites[Random.Range(0, sprites.Length)]);
        current.GetComponent<SpriteRenderer>().color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        spriteMan.spigs.Add(current);
        follow = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (follow)
        {
            mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            current.transform.position = Vector2.Lerp(current.transform.position, mousePosition, moveSpeed);
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                current.transform.Rotate(Vector3.forward * speedrotate * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                current.transform.Rotate(Vector3.back * speedrotate * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.UpArrow))
            {
                current.transform.localScale += new Vector3(0.01f, 0.01f, 1);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                current.transform.localScale -= new Vector3(0.01f, 0.01f, 1);
            }
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            follow = false;
            Instantiate(current);
            selectcurrent();
        }       
    }
}
