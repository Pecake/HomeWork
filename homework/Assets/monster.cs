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
    ///���ʳt��
    [Header("���ʳt��"),Range(1,10)]
    public float speed = 3.5f;

    [Header("�����O"), Range(0, 500)]
    public float attack = 100;

    [Header("��q"), Range(0, 5000)]
    public float HP = 350;

    [Header("�l�ܽd��"), Range(0, 50)]
    public float rangTrack = 30;

    [Header("�l�ܦ첾")]
    public Vector3 offsetTrack;

    [Header("�����D��")]
    public GameObject prop;

    [Range(0, 1)]
    public float probablity = 1;

    [Header("����")]
    public AudioClip soundDropProp;
    public AudioClip soundHurt;
    public AudioClip soundAttack;

    private AudioSource aud;
    private Rigidbody2D rig;
    private Animator ani;

}
