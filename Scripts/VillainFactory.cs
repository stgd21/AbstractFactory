using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillainFactory : ICharacterFactory
{
    public ICharacter Create(Requirements requirements)
    {
        switch (requirements.range)
        {
            case 1:
            case 2:
            case 3:
                return new Tank(Color.black);
            default:
                return new Archer(Color.black);
        }
    }
}
