namespace SRP
{
    public abstract class Character
    {
        public int Health { get; set; }
        public virtual void Attack(Character target)
        {
            if (CanHit(this, target))
            {
                DamageCalculator dc = new DamageCalculator();
                int damage = dc.GetDamage(this, target);
                target.TakeDamage(damage);
            }
        }

        private bool CanHit(Character character, Character target)
        {
            ProximityCalculator pc = new ProximityCalculator();
            bool inRange = pc.IsInRange(character, target);
            return inRange;
        }

        private void TakeDamage(int damage)
        {
            Health -= damage;
        }
    }
}
