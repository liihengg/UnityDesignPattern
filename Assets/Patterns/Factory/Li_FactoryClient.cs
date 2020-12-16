using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Li_FactoryClient : MonoBehaviour
{

    void Start()
    {
        Api api = Li_Factory.CreateApi(1);
        api.Operation("使用工厂");
    }


}
