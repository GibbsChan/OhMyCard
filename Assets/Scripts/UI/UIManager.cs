using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    // TODO����ʵ��һ��������in common��
    public static UIManager Instance;

    private Transform UITrf; 

    void Awake()
    {
        Instance = this;
        UITrf = GameObject.Find("UI/GameUI").transform;
    }
}
