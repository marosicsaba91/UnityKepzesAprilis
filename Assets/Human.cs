using UnityEngine;

public class Human : MonoBehaviour
{
    [SerializeField] string firstName = "NO NAME";
    [SerializeField] string familyName = "NO NAME";
    [SerializeField, Min(1900)] int born = 1950;
    [SerializeField, Range(50, 300)] float height = 160;
    [SerializeField] bool isAlive = true;

    [Space]
    [SerializeField] bool blabla;
    [SerializeField] bool krixkrax;

    // BLABLA
    //  �lnie kell
    //  Magasabb 165 cm-n�l, de kisebb 200-n�l.
    //  2000 vagy az ut�n sz�letetek.

    // KRIXKRAX
    //  Kisebb 180 cm-n�l, vagy nagyobb 210-n�l.
    //  Instant felvesznek, ha a keresztneved �s a vezet�kneved megegyezik.

    void OnValidate()
    {
        bool isHeightRight = height > 165 && height < 200;
        bool isAgeRight = born >= 2000;

        blabla = isAlive && isHeightRight && isAgeRight;

        isHeightRight = height < 180 || height > 210;
        bool isNameRight = firstName == familyName;
        krixkrax = isHeightRight || isNameRight;
    }
}
