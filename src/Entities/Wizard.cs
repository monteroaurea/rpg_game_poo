namespace POO.src.Entities
{
    public class Wizard : Hero

    {
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack(){
        return this.Name + " Lançou feitiço";
        }
       public string Attack(int Bonus){

        if (Bonus > 6){
           return this.Name+ " Lançou feitiço com força forte com bonus de " + Bonus;
        }else{
            return this.Name+ " Lançou feitiço com força fraca com bonus de " + Bonus;
        }
    }