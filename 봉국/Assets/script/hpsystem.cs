using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hpsystem : MonoBehaviour
{
    public int maxhp = 5;
    public int hp;
    public GameObject MainObject;
    public Text hptext;
    // Use this for initialization
    void Start()
    {
        hp = maxhp;
        Debug.Log("hp:" + hp);
        hptext.text = hp.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("obstacle"))
        {
            Debug.Log("충돌");
            hp -= 1;
            Debug.Log("hp:" + hp);
            hptext.text = hp.ToString();
        }
    }
}