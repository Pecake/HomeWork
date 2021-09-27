using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    ///對話功能
    ///talk:對話內容
    private void Talk(string talk)
    {

    }

    ///更新任務
    ///propMission:任務道具編號
    private int UpdateMission(int propMission = 1)
    {
        return 0;
    }

    ///完成任務
    ///induxmission:任務編號
    private bool FinishMission(int induxmission)
    {
        return false;
    }
    ///開啟商店
    public bool OpenShop()
    {
        return true;
    }

    ///購買道具
    ///price:道具價格
    public int BuyProp(int price = 100)
    {
        return 0;
    }

    ///取得任務
    ///indexmission:任務編號
    public void GetMission(int indexmission)
    {

    }
}
