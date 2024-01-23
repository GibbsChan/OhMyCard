using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppMain : MonoBehaviour
{
    private void Awake()
    {
        this.gameObject.AddComponent<UIManager>();
    }

    void Start()
    {
        // NOTE�����������Ҫ��prefab������һ��
        // Ӧ�ø�Ϊÿһ��UI�ű�����һ�����֣�����ע��Dict
        // �ļ�ʹ��addressable����ע������첽���أ�
        UIManager.Instance.ShowUI<LoginView>("LoginUI");
    }

    void Update()
    {
        
    }
}
