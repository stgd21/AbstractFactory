using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterFactory : AbstractCharacterFactory
{
    public override ICharacterFactory HeroFactory()
    {
        return new HeroFactory();
    }

    public override ICharacterFactory VillainFactory()
    {
        return new VillainFactory();
    }
}
