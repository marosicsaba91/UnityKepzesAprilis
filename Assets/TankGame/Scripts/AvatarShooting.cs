using System;
using UnityEngine;

public class AvatarShooting : MonoBehaviour
{
    [SerializeField] GameObject projectilePrototype;
    [SerializeField] Transform projectileStartPosition;

    [SerializeField] Damagable damagabe;
    [SerializeField] AvatarInput input;

    void OnValidate()
    {
        if (damagabe == null)
            damagabe = GetComponentInChildren<Damagable>();
        if (input == null)
            input = GetComponentInChildren<AvatarInput>();
    }

    void Update()
    {
        if (damagabe.health > 0)
        { 
            TryShoot();
        }
    }

    void TryShoot()
    {
        if (input.IsShooting())
        {
            GameObject go = Instantiate(projectilePrototype);
            go.SetActive(true);
            Projectile p = go.GetComponent<Projectile>();

            Vector3 forward = transform.forward;
            go.transform.position = projectileStartPosition.position;
            p.Shoot(forward);
        }
    }

}
