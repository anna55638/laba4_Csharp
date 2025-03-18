using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// БУДТЕ ВНИМАТЕЛЬНЕЕ: ТУТ ДОЛЖЕН СТОЯТЬ ТОТ ЖЕ namespace что и в Program.cs
namespace laba4_Csharp
{
    // Базовый класс
    public class MagicalArtifact
    {
        public int MagicLevel { get; set; }

        public MagicalArtifact(int magicLevel)
        {
            MagicLevel = magicLevel;
        }

        public virtual string GetInfo()
        {
            return $"Магический уровень: {MagicLevel}";
        }
    }

    // Класс-наследник: Магический меч
    public class MagicSword : MagicalArtifact
    {
        public int Sharpness { get; set; }
        public string Element { get; set; }

        public MagicSword(int magicLevel, int sharpness, string element) : base(magicLevel)
        {
            Sharpness = sharpness;
            Element = element;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $", Острота: {Sharpness}, Элемент: {Element}";
        }

        public static MagicSword Generate()
        {
            var rnd = new Random();
            return new MagicSword(
                magicLevel: rnd.Next(1, 101),
                sharpness: rnd.Next(1, 101),
                element: new[] { "Огонь", "Лед", "Молния" }[rnd.Next(3)]
            );
        }
    }

    // Класс-наследник: Магический амулет
    public class MagicAmulet : MagicalArtifact
    {
        public int Protection { get; set; }
        public string Effect { get; set; }

        public MagicAmulet(int magicLevel, int protection, string effect) : base(magicLevel)
        {
            Protection = protection;
            Effect = effect;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $", Защита: {Protection}, Эффект: {Effect}";
        }

        public static MagicAmulet Generate()
        {
            var rnd = new Random();
            return new MagicAmulet(
                magicLevel: rnd.Next(1, 101),
                protection: rnd.Next(1, 101),
                effect: new[] { "Исцеление", "Невидимость", "Усиление" }[rnd.Next(3)]
            );
        }
    }

    // Класс-наследник: Магический свиток
    public class MagicScroll : MagicalArtifact
    {
        public string Spell { get; set; }
        public int Duration { get; set; }

        public MagicScroll(int magicLevel, string spell, int duration) : base(magicLevel)
        {
            Spell = spell;
            Duration = duration;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $", Заклинание: {Spell}, Длительность: {Duration} мин.";
        }

        public static MagicScroll Generate()
        {
            var rnd = new Random();
            return new MagicScroll(
                magicLevel: rnd.Next(1, 101),
                spell: new[] { "Огненный шар", "Ледяная стрела", "Молния" }[rnd.Next(3)],
                duration: rnd.Next(1, 61)
            );
        }
    }
}