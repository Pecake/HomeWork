using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monster : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    ///移動速度
    [Header("移動速度"),Range(1,10)]
    public float speed = 3.5f;

    [Header("攻擊力"), Range(0, 500)]
    public float attack = 100;

    [Header("血量"), Range(0, 5000)]
    public float HP = 350;

    [Header("追蹤範圍"), Range(0, 50)]
    public float rangTrack = 30;

    [Header("追蹤位移")]
    public Vector3 offsetTrack;

    [Header("掉落道具")]
    public GameObject prop;

    [Range(0, 1)]
    public float probablity = 1;

    [Header("音效")]
    public AudioClip soundDropProp;
    public AudioClip soundHurt;
    public AudioClip soundAttack;

    private AudioSource aud;
    private Rigidbody2D rig;
    private Animator ani;

}
