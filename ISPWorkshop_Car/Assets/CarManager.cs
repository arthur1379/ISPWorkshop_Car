using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CarManager : MonoBehaviour {

    [SerializeField]
    GameObject Car;

    [SerializeField]
    Vector3 P1, P2;

    [SerializeField]
    Vector3[] OilPos;

    Vector3 CarInsPos;

    float timer;
    float CarInstimer = 5.0f;

    public Ease MoveEaseFunction; // 宣告Dotween函式庫中的Ease 名稱為RotateEaseFunction

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        timer += Time.deltaTime;

        if (timer >= CarInstimer)
        {
            CarIns();
        }
	}

    void CarIns()
    {
        timer = 0;

        int Row = Random.Range(0, 1);
        if (Row == 0)
            CarInsPos = P1;
        else
            CarInsPos = P2;

        GameObject m_Car = Instantiate(Car, CarInsPos, transform.rotation);

        int RandomOilPos = Random.Range(0, 5);

        m_Car.transform.DOMove(OilPos[RandomOilPos], 3);

    }
}
