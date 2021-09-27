using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class player : MonoBehaviour
{
    #region ��� Field
    //�x�s�C����ơA�Ҧp:���ʳt�סA���D���׵�
    //���(int)�A�B�I��(float)�A���L��(bool)�A�r��(string)
    //���y�k:�׹����B��������B���W��(���w �w�]��)����
    //�׹���:
    //1.���}public-���\��L���O�s��-��ܦb�ݩʭ��O-�ݭn�H�ɽվ㪺���
    //2.�p�Hprivate-�T���L���O�s��-���æb�ݩʭ��O-�w�]��
    //����ݩ�:���U�Х�����ƷN�q
    //����ݩʻy�k:[�ݩʦW��(�ݩʭ�)]
    //Header �ݩʼ��D
    //Tootips ����:�ƹ����d�b�ݩʤW�|���X��r�`��
    //Range�d��:�ϥΩ�ƭȫ���ƤW(int,float)
    [Header("���ʳt��"), Tooltip("�վ㨤�Ⲿ�ʳt��"), Range(0, 500)]
    public float Speed = 10.5f;
    [Header("���D����"), Tooltip("�վ㨤����D����"), Range(0, 1000)]
    public float jump = 100;
    [Header("�O�_�b�a�O�W"), Tooltip("�P�_����O�_�b�a�O�W")]
    public bool playerplane;
    [Header("�ˬd�a�O�첾")]
    public Vector3 v3;
    [Header("�ˬd�a�O�b�|"), Range(0, 3)]
    public float planeR = 0.2f;
    [Header("���D����")]
    public VideoClip jumpsound;
    [Header("���a����")]
    public VideoClip Groundsound;
    [Header("�ʵe")]
    public string walk = "�����}��";
    public string run = "�b�]�}��";
    public string hit = "����Ĳ�o";
    public string dead = "���`�}��";

    private AudioSource audioSource;
    private Animator playercontrol;
    private Rigidbody rig;


    /**
    #region Unity�������
    //�C��
    public Color color;
    public Color white = Color.white;
    public Color red = Color.red;   //�����C��
    public Color color1 = new Color(0.2f, 0.5f, 0);   //�ۭq�C��RGB
    public Color color2 = new Color(0.2f, 0.5f, 0, 0.5f);  //�ۭq�C��A�z����RGBA

    //�y�� Vector2-4
    public Vector2 v2;
    public Vector2 v2R = Vector2.right;
    public Vector2 v2D = Vector2.down;
    public Vector2 a = new Vector2(1f, 2.5f);
    public Vector3 b = new Vector3(3f, 2.1f, 0.5f);
    public Vector4 c = new Vector4(3.5f, 2.5f, 1.6f, 3.3f);

    //���� �C�|���  enum
    public KeyCode key;
    public KeyCode walk = KeyCode.W;
    public KeyCode jump = KeyCode.Space;


    //�C���������:������w�w�]��
    public AudioClip sound;  //����  mp3
    public VideoClip video;  //�v��  mp4
    public Sprite picture;  //  �Ϥ�  png,jpeg
    public Texture2D texture2D;  //2d�Ϥ�  jpeg,png
    public Material material;  //����y

    [Header("����")]
    public Transform site;  //��m
    public Animation animation;   //�ʵe
    public Light ppp;   //����
    public Camera haha;   //��v��
    #endregion

    #region �ݩ� Property
    #endregion
    #region ��k Method
    #endregion
    #region �ƥ� Event
    /**/
    #endregion

    #region �ݩ�(�ܼ�) property
    /**�ݩʽm��
    //�x�s���:�P���ۦP
    //�t���B:�i�H�]�w�s���v��
    //�ݩʻy�k:�׹��� ������� �ݩʦW�� {��;�s;}
    public int readAndwrite { get; set; }

    //��Ū�ݩ�:�u��Ū��
    //�߼g�ݩ�:�T��A�����n��get
    //public int write{set;} X
    public int read {

        get
        {
            return 15;
        }
    }

    private int hp;
    public int Hp
    {
        get
        {
            return Hp;
        }
        set
        {
            Hp = value;
        }
    }
    /**/



    #endregion

    #region ��k  Method
    //�w�q�P��@���������{���϶��A�\��
    //��k�y�k:�׹��� �Ǧ^������� ��k�W��(�Ѽ�1,...�Ѽ�N){�{���϶�}
    //�`�ζǦ^����:�L�Ǧ^ void-����k�S���Ǧ^���
    //�����۰ʾ�z:Ctrl+K+D
    //�ۭq��k:
    //�n�Q�I�s�~������k������{��
    //�W���C�⬰�H����-�S���Q�I�s
    //�W���C�⬰�G����-���Q�I�s

    private void Walk(float speed)
    {

    }

    private float InputWalk()
    {
        return 0f;
    }

    private bool IsGround()
    {
        return false;
    }

    private void Jump()
    {

    }

    private void NewAnimation()
    {

    }

    #region �ۭq�q��k
    //private void Test()
    //{
    //  print("�ڬO�j�ӭ�");
    //}
    // private int eee()
    //{
    //  return 14;
    //}
    #endregion


    #region �ѼƤ�k
    //�Ѽƻy�k:������� �ѼƦW�� ���w �w�]��
    //���w�]�Ȫ��Ѽƥi�H����J�޼ơA�٬���񦡰Ѽ�
    //��񦡰Ѽƥu���b()�k��


    //private void Skill(int damage, string video = "hahaha", string sound = "yoyoyo")
    //{
    //  print("�Ѽƪ���-�ˮ`��:" + damage + "�ޯ�S��" + video + "����" + sound);

    //}
    #endregion

    #endregion

    #region �ƥ� Event
    //�S�w�ɶ��I�|���檺��k�A�{���J�f
    //�}�l�ƥ�C���}�l�ɰ���@���A�B�z��l�ơA���o��Ƶ���
    // private void Start()
    //{
    //  print("hahaha");
    //Debug.Log("�@��T��");
    //Debug.LogWarning("ĵ�i�T��");
    //Debug.LogError("���~�T��");

    //}
    /**
    //�ݩʽm��
 private void Start()
    {

    print("��Ū�ݩ�-�u��Ū��"+read);

    print("��q:" + hp);
        hp = 100;
        print("��q:" + hp);

    }
    /**/

    #region �I�s��k���y�k:��k�W��();


    #endregion
    public void Start()
    {
        #region �I�s�ۭq�q��k
        // Test();
        //1.�ϰ��ܼ�
        //int a = eee();
        //print(a);
        //2.�N�ۭq��k��@�ƭ�
        //print("���B�Ʀr=" + (eee() + 1));
        #endregion

        #region �I�s�ѼƤ�k
        //�I�s�ѼƤ�k�ɡA������J�����޼�
        //  Skill(150);
        //���w
        //Skill(300, sound: "tmd");
        #endregion

    }
    public void Update()
    {

    }
    #endregion

    #region �I�s��k���y�k:��k�W��();


    #endregion
}
