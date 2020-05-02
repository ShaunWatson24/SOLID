namespace SRP
{
    public class DamageCalculator
    {
        public DamageCalculator()
        {
        }

        public DamageCalculator(Battle battle)
        {
            this.Battle = battle;
        }

        public int GetDamage(Character source, Character target)
        {
            //Perform Calculations to Determine Damage Inflicted
            //int baseDamage = source.Strength * 2 + source.Weapon.DamageRating;
            //int armorReduction = target.Armor.ArmorRating;
            //int physicalDamage = baseDamage - Math.Min(armorReduction, baseDamage);
            //int pierceDamage = (int)(source.Weapon.PierceDamage / target.Armor.PierceResistance);...
            return 100;
        }

        protected Battle Battle { get; private set; }
    }
}
