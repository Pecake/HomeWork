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
    ///��ܥ\��
    ///talk:��ܤ��e
    private void Talk(string talk)
    {

    }

    ///��s����
    ///propMission:���ȹD��s��
    private int UpdateMission(int propMission = 1)
    {
        return 0;
    }

    ///��������
    ///induxmission:���Ƚs��
    private bool FinishMission(int induxmission)
    {
        return false;
    }
    ///�}�Ұө�
    public bool OpenShop()
    {
        return true;
    }

    ///�ʶR�D��
    ///price:�D�����
    public int BuyProp(int price = 100)
    {
        return 0;
    }

    ///���o����
    ///indexmission:���Ƚs��
    public void GetMission(int indexmission)
    {

    }
}
