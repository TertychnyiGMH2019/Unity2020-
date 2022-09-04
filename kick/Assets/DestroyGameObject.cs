using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGameObject : MonoBehaviour
{
    public GameObject ObjectNew; // Новый объект
    public GameObject ObjectOld; // Старый объект
    public int Health; // Здоровье объекта

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        /*
         * Если здоровье объекта меньше или равно 0, то дезактивировать старый объект
         * и активировать новый объект
         */
        if (Health <= 0)
        {
            ObjectNew.SetActive(true);
            ObjectOld.SetActive(false);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        /*
         * Если сопрекоснётся коллизия с объектом с тегом Destroy, то здоровье уменьшится на единицу
         */
        if (collision.collider.tag == "Destroy")
        {
            Health -= 1;
        }
    }
}
