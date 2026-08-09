abstract class Character
{
    protected string characterType;
    public bool isVulnerable = false;
    
    protected Character(string characterType)
    {
        this.characterType = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable() => isVulnerable;

    public override string ToString() => $"Character is a {characterType}";
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target) => target.isVulnerable ? 10 : 6;
}

class Wizard : Character
{
    public Wizard() : base("Wizard")
    {
        isVulnerable = true;
    }

    public override int DamagePoints(Character target) => isVulnerable ? 3 : 12;

    public void PrepareSpell()
    {
        isVulnerable = false;
    }
}
