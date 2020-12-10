using DungeonCrawler.Data;
using DungeonCrawler.Data.Abstractions;
using DungeonCrawler.Data.Enums;
using System;

namespace DungeonCrawler.Domain.Factories
{
    public static class MoveFactory
    {
        public static Move CreateNewByTypeFor(MoveType moveType, Character attacker)
        {
            if (moveType == MoveType.DirectAttack)
            {
                return new DirectAttack(attacker);
            }

            if (moveType == MoveType.SideAttack)
            {
                return new SideAttack(attacker);
            }

            if (moveType == MoveType.CounterAttack)
            {
                return new CounterAttack(attacker);
            }

            throw new Exception("Invalid move type chosen!");
        }
    }
}
