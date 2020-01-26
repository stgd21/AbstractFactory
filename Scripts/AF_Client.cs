using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AF_Client : MonoBehaviour
{
    public Slider rangeValues;
    [Header("Color determination")]
    public bool newIsEvil = true;
    [Header("Archer if greater than 3 (out of 5 total)")]
    public int range = 2;


    private Requirements requirements;
    private ICharacter newCharacter;
    // Start is called before the first frame update
    void Start()
    {
        requirements = new Requirements();
        requirements.isEvil = newIsEvil;
        requirements.range = range;
    }

    private static ICharacter GetCharacter(Requirements requirements)
    {
        CharacterFactory factory = new CharacterFactory();

        if (requirements.isEvil == true)
            return factory.VillainFactory().Create(requirements);
        else
            return factory.HeroFactory().Create(requirements);
    }

    public void Create()
    {
        newCharacter = GetCharacter(requirements);
        newCharacter.Spawn();
    }

    public void ToggleEvil()
    {
        requirements.isEvil = !requirements.isEvil;
    }

    public void SetNewRange()
    {
        requirements.range = (int)rangeValues.value;
    }

    public void DestroyAll()
    {
        GameObject[] allCharacters = GameObject.FindGameObjectsWithTag("Character");
        for (int i = 0; i < allCharacters.Length; i++)
            Destroy(allCharacters[i]);
    }
}
