using System;
using TMPro;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI getItemText;
    [SerializeField] private TextMeshProUGUI gameClearText;


    private void Update()
    {
        //todo Restartボタンを付けてリスタートする機能の追加
    }

    public void SetGetItemCount(int itemCount)
    {
        getItemText.text = $"Count:{itemCount}";
    }

    public void SetViewGameClear(bool isView)
    {
        gameClearText.gameObject.SetActive(isView);
    }
}