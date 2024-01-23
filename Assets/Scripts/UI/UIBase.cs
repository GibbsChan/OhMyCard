using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * �������
 */ 

public class UIBase : MonoBehaviour
{
    public virtual void Show()
    {
        this.gameObject.SetActive(true);
    }

    public virtual void Hide()
    {
        this.gameObject.SetActive(false);
    }

    public virtual void Close()
    {

    }

    public virtual void Reset()
    {

    }

    public void OnDestroy()
    {

    }
}
