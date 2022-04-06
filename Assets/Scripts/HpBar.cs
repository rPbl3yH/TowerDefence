using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBar : MonoBehaviour
{
    public Enemy enemy;
    public GameObject PrefabHp;

    public GameObject canvas;
    public GameObject hpText;

    // Start is called before the first frame update
    void Start()
    {
        enemy = GetComponentInParent<Enemy>();
        hpText = Instantiate(PrefabHp, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        hpText.transform.SetParent(canvas.transform);
        hpText.transform.position = Camera.main.WorldToScreenPoint(enemy.transform.position) + new Vector3(0,10,0);

        hpText.GetComponent<Text>().text = enemy.currentHp.ToString();
    }
}
