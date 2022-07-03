using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByBoundary : MonoBehaviour
{   
    void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
    } 
}

// Bir küp oluşturup sadece Rigidbody ve Box Collider ekledik.
// Collider, oyun sahnesi genişliğine getirildi.
// Yukarda yazdığımız fonksiyon eğer bir oyun objesi, Collider dışarısına
// çıkarsa Destroy() fonksiyonu sayesinde yok edilmesini sağlar.

