using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class player : MonoBehaviour
{
    #region 欄位 Field
    //儲存遊戲資料，例如:移動速度，跳躍高度等
    //整數(int)，浮點數(float)，布林值(bool)，字串(string)
    //欄位語法:修飾詞、資料類型、欄位名稱(指定 預設值)結尾
    //修飾詞:
    //1.公開public-允許其他類別存取-顯示在屬性面板-需要隨時調整的資料
    //2.私人private-禁止其他類別存取-隱藏在屬性面板-預設值
    //欄位屬性:輔助標示欄位資料意義
    //欄位屬性語法:[屬性名稱(屬性值)]
    //Header 屬性標題
    //Tootips 提示:滑鼠停留在屬性上會跳出文字注釋
    //Range範圍:使用於數值型資料上(int,float)
    [Header("移動速度"), Tooltip("調整角色移動速度"), Range(0, 500)]
    public float Speed = 10.5f;
    [Header("跳躍高度"), Tooltip("調整角色跳躍高度"), Range(0, 1000)]
    public float jump = 100;
    [Header("是否在地板上"), Tooltip("判斷角色是否在地板上")]
    public bool playerplane;
    [Header("檢查地板位移")]
    public Vector3 v3;
    [Header("檢查地板半徑"), Range(0, 3)]
    public float planeR = 0.2f;
    [Header("跳躍音效")]
    public VideoClip jumpsound;
    [Header("落地音效")]
    public VideoClip Groundsound;
    [Header("動畫")]
    public string walk = "走路開關";
    public string run = "奔跑開關";
    public string hit = "受傷觸發";
    public string dead = "死亡開關";

    private AudioSource audioSource;
    private Animator playercontrol;
    private Rigidbody rig;


    /**
    #region Unity資料類型
    //顏色
    public Color color;
    public Color white = Color.white;
    public Color red = Color.red;   //內建顏色
    public Color color1 = new Color(0.2f, 0.5f, 0);   //自訂顏色RGB
    public Color color2 = new Color(0.2f, 0.5f, 0, 0.5f);  //自訂顏色，透明度RGBA

    //座標 Vector2-4
    public Vector2 v2;
    public Vector2 v2R = Vector2.right;
    public Vector2 v2D = Vector2.down;
    public Vector2 a = new Vector2(1f, 2.5f);
    public Vector3 b = new Vector3(3f, 2.1f, 0.5f);
    public Vector4 c = new Vector4(3.5f, 2.5f, 1.6f, 3.3f);

    //按鍵 列舉資料  enum
    public KeyCode key;
    public KeyCode walk = KeyCode.W;
    public KeyCode jump = KeyCode.Space;


    //遊戲資料類型:不能指定預設值
    public AudioClip sound;  //音效  mp3
    public VideoClip video;  //影片  mp4
    public Sprite picture;  //  圖片  png,jpeg
    public Texture2D texture2D;  //2d圖片  jpeg,png
    public Material material;  //材質球

    [Header("元件")]
    public Transform site;  //位置
    public Animation animation;   //動畫
    public Light ppp;   //光源
    public Camera haha;   //攝影機
    #endregion

    #region 屬性 Property
    #endregion
    #region 方法 Method
    #endregion
    #region 事件 Event
    /**/
    #endregion

    #region 屬性(變數) property
    /**屬性練習
    //儲存資料:與欄位相同
    //差異處:可以設定存取權限
    //屬性語法:修飾詞 資料類型 屬性名稱 {取;存;}
    public int readAndwrite { get; set; }

    //唯讀屬性:只能讀取
    //唯寫屬性:禁止，必須要有get
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

    #region 方法  Method
    //定義與實作較複雜的程式區塊，功能
    //方法語法:修飾詞 傳回資料類型 方法名稱(參數1,...參數N){程式區塊}
    //常用傳回類型:無傳回 void-此方法沒有傳回資料
    //版面自動整理:Ctrl+K+D
    //自訂方法:
    //要被呼叫才能執行方法內的方程式
    //名稱顏色為淡黃色-沒有被呼叫
    //名稱顏色為亮黃色-有被呼叫

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

    #region 自訂義方法
    //private void Test()
    //{
    //  print("我是大帥哥");
    //}
    // private int eee()
    //{
    //  return 14;
    //}
    #endregion


    #region 參數方法
    //參數語法:資料類型 參數名稱 指定 預設值
    //有預設值的參數可以不輸入引數，稱為選填式參數
    //選填式參數只能放在()右邊


    //private void Skill(int damage, string video = "hahaha", string sound = "yoyoyo")
    //{
    //  print("參數版本-傷害值:" + damage + "技能特效" + video + "音效" + sound);

    //}
    #endregion

    #endregion

    #region 事件 Event
    //特定時間點會執行的方法，程式入口
    //開始事件遊戲開始時執行一次，處理初始化，取得資料等等
    // private void Start()
    //{
    //  print("hahaha");
    //Debug.Log("一般訊息");
    //Debug.LogWarning("警告訊息");
    //Debug.LogError("錯誤訊息");

    //}
    /**
    //屬性練習
 private void Start()
    {

    print("唯讀屬性-只能讀取"+read);

    print("血量:" + hp);
        hp = 100;
        print("血量:" + hp);

    }
    /**/

    #region 呼叫方法的語法:方法名稱();


    #endregion
    public void Start()
    {
        #region 呼叫自訂義方法
        // Test();
        //1.區域變數
        //int a = eee();
        //print(a);
        //2.將自訂方法當作數值
        //print("幸運數字=" + (eee() + 1));
        #endregion

        #region 呼叫參數方法
        //呼叫參數方法時，必須輸入對應引數
        //  Skill(150);
        //指定
        //Skill(300, sound: "tmd");
        #endregion

    }
    public void Update()
    {

    }
    #endregion

    #region 呼叫方法的語法:方法名稱();


    #endregion
}
