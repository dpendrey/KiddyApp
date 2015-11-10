using System;
using System.Collections.Generic;
using System.Text;

namespace KiddyApp.Cards.Source1
{
    public class Apple : Card
    {
        public override string Text
        {
            get { return "Apple"; }
        }

        public override double DifficultyModifier
        {
            get { return Card.DifficultyStandard; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source1._1_Apple); }
        }

        public override string[] Groups
        {
            get { return new string[] { "Fruit", "Food" }; }
        }

        public override string[] MainColours
        {
            get { return new string[] { "Red" }; }
        }
    }
    public class Butterfly : Card
    {
        public override string Text
        {
            get { return "Butterfly"; }
        }

        public override double DifficultyModifier
        {
            get { return Card.DifficultyBitHigh; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source1._1_Butterfly); }
        }

        public override string[] Groups
        {
            get { return new string[] { "Animal" ,"Sky"}; }
        }

        public override string[] MainColours
        {
            get { return new string[] { "Purple" }; }
        }
    }
    public class Cat : Card
    {
        public override string Text
        {
            get { return "Cat"; }
        }

        public override double DifficultyModifier
        {
            get { return Card.DifficultyEasy; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source1._1_Cat); }
        }

        public override string[] Groups
        {
            get { return new string[] { "Animal" }; }
        }

        public override string[] MainColours
        {
            get { return new string[] { "Grey" }; }
        }
    }
    public class Doll : Card
    {
        public override string Text
        {
            get { return "Doll"; }
        }

        public override double DifficultyModifier
        {
            get { return Card.DifficultyEasy; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source1._1_Doll); }
        }

        public override string[] Groups
        {
            get { return new string[] { "Doll", "Toy" }; }
        }

        public override string[] MainColours
        {
            get { return new string[] { "Red" }; }
        }
    }
    public class Egg : Card
    {
        public override string Text
        {
            get { return "Egg"; }
        }

        public override double DifficultyModifier
        {
            get { return Card.DifficultyEasy; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source1._1_Egg); }
        }

        public override string[] Groups
        {
            get { return new string[] { "Kitchen", "Food" }; }
        }

        public override string[] MainColours
        {
            get { return new string[] { "White" }; }
        }
    }
    public class Flower : Card
    {
        public override string Text
        {
            get { return "Flower"; }
        }

        public override double DifficultyModifier
        {
            get { return Card.DifficulySomewhatEasy; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source1._1_Flower); }
        }

        public override string[] Groups
        {
            get { return new string[] { "Plant" }; }
        }

        public override string[] MainColours
        {
            get { return new string[] { "Yellow" }; }
        }
    }
    public class Goat : Card
    {
        public override string Text
        {
            get { return "Goat"; }
        }

        public override double DifficultyModifier
        {
            get { return Card.DifficultyStandard; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source1._1_Goat); }
        }

        public override string[] Groups
        {
            get { return new string[] { "Animal" }; }
        }

        public override string[] MainColours
        {
            get { return new string[] { "White" }; }
        }
    }
    public class Heart : Card
    {
        public override string Text
        {
            get { return "Heart"; }
        }

        public override double DifficultyModifier
        {
            get { return Card.DifficulySomewhatEasy; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source1._1_Heart); }
        }

        public override string[] Groups
        {
            get { return new string[0]; }
        }

        public override string[] MainColours
        {
            get { return new string[] { "Pink" }; }
        }
    }
    public class Ice_Cream : Card
    {
        public override string Text
        {
            get { return "Ice Cream"; }
        }

        public override double DifficultyModifier
        {
            get { return Card.DifficulySomewhatEasy; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source1._1_Ice_Cream); }
        }

        public override string[] Groups
        {
            get { return new string[] { "Food","Cold"}; }
        }

        public override string[] MainColours
        {
            get { return new string[] { "Brown", "White", "Pink" }; }
        }
    }
    public class Jar : Card
    {
        public override string Text
        {
            get { return "Jar"; }
        }

        public override double DifficultyModifier
        {
            get { return Card.DifficultyEasy; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source1._1_Jar); }
        }

        public override string[] Groups
        {
            get { return new string[] { "Food", "Kitchen" }; }
        }

        public override string[] MainColours
        {
            get { return new string[] { "Red" }; }
        }
    }
    public class Kite : Card
    {
        public override string Text
        {
            get { return "Kite"; }
        }

        public override double DifficultyModifier
        {
            get { return Card.DifficultyStandard; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source1._1_Kite); }
        }

        public override string[] Groups
        {
            get { return new string[]{ "Toy","Sky"}; }
        }

        public override string[] MainColours
        {
            get { return new string[] { "Red", "Green", "Yellow", "Blue" }; }
        }
    }
    public class Ladybug : Card
    {
        public override string Text
        {
            get { return "Ladybug"; }
        }

        public override double DifficultyModifier
        {
            get { return Card.DifficultyStandard; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source1._1_Ladybug); }
        }

        public override string[] Groups
        {
            get { return new string[] { "Animal" }; }
        }

        public override string[] MainColours
        {
            get { return new string[] { "Red" }; }
        }
    }
    public class Moon : Card
    {
        public override string Text
        {
            get { return "Moon"; }
        }

        public override double DifficultyModifier
        {
            get { return Card.DifficulySomewhatEasy; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source1._1_Moon); }
        }

        public override string[] Groups
        {
            get { return new string[]{"Night", "Sky"}; }
        }

        public override string[] MainColours
        {
            get { return new string[] { "Yellow" }; }
        }
    }
    public class Nest : Card
    {
        public override string Text
        {
            get { return "Nest"; }
        }

        public override double DifficultyModifier
        {
            get { return Card.DifficultyStandard; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source1._1_Nest); }
        }

        public override string[] Groups
        {
            get { return new string[] { "Animal" }; }
        }

        public override string[] MainColours
        {
            get { return new string[] { "Brown" }; }
        }
    }
    public class Orange : Card
    {
        public override string Text
        {
            get { return "Orange"; }
        }

        public override double DifficultyModifier
        {
            get { return Card.DifficultyBitHigh; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source1._1_Orange); }
        }

        public override string[] Groups
        {
            get { return new string[] { "Fruit", "Food" }; }
        }

        public override string[] MainColours
        {
            get { return new string[] { "Orange" }; }
        }
    }
    public class Pear : Card
    {
        public override string Text
        {
            get { return "Pear"; }
        }

        public override double DifficultyModifier
        {
            get { return Card.DifficultyBitHigh; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source1._1_Pear); }
        }

        public override string[] Groups
        {
            get { return new string[] { "Fruit", "Food" }; }
        }

        public override string[] MainColours
        {
            get { return new string[] { "Green" }; }
        }
    }
    public class Queen : Card
    {
        public override string Text
        {
            get { return "Queen"; }
        }

        public override double DifficultyModifier
        {
            get { return Card.DifficultyBitHigh; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source1._1_Queen); }
        }

        public override string[] Groups
        {
            get { return new string[] { "Person" }; }
        }

        public override string[] MainColours
        {
            get { return new string[] { }; }
        }
    }
    public class Rocket : Card
    {
        public override string Text
        {
            get { return "Rocket"; }
        }

        public override double DifficultyModifier
        {
            get { return Card.DifficultyBitHigh; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source1._1_Rocket); }
        }

        public override string[] Groups
        {
            get { return new string[]{ "Sky"}; }
        }

        public override string[] MainColours
        {
            get { return new string[] { "Silver", "Red" }; }
        }
    }
    public class Sun : Card
    {
        public override string Text
        {
            get { return "Sun"; }
        }

        public override double DifficultyModifier
        {
            get { return Card.DifficultyEasy; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source1._1_Sun); }
        }

        public override string[] Groups
        {
            get { return new string[]{ "Sky"}; }
        }

        public override string[] MainColours
        {
            get { return new string[] { "Yellow" }; }
        }
    }
    public class Teddy : Card
    {
        public override string Text
        {
            get { return "Teddy"; }
        }

        public override double DifficultyModifier
        {
            get { return Card.DifficultyEasy; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source1._1_Teddy); }
        }

        public override string[] Groups
        {
            get { return new string[] { "Doll" ,"Toy"}; }
        }

        public override string[] MainColours
        {
            get { return new string[] { "Brown" }; }
        }
    }
    public class Umbrella : Card
    {
        public override string Text
        {
            get { return "Umbrella"; }
        }

        public override double DifficultyModifier
        {
            get { return Card.DifficultyBitHigh; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source1._1_Umbrella); }
        }

        public override string[] Groups
        {
            get { return new string[] { }; }
        }

        public override string[] MainColours
        {
            get { return new string[] { "Blue" }; }
        }
    }
    public class Violin : Card
    {
        public override string Text
        {
            get { return "Violin"; }
        }

        public override double DifficultyModifier
        {
            get { return Card.DifficultyModerate; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source1._1_Violin); }
        }

        public override string[] Groups
        {
            get { return new string[] { "Music" }; }
        }

        public override string[] MainColours
        {
            get { return new string[] { "Brown" }; }
        }
    }
    public class Whale : Card
    {
        public override string Text
        {
            get { return "Whale"; }
        }

        public override double DifficultyModifier
        {
            get { return Card.DifficultyBitHigh; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source1._1_Whale); }
        }

        public override string[] Groups
        {
            get { return new string[] { "Animal","Ocean" }; }
        }

        public override string[] MainColours
        {
            get { return new string[] { "Blue" }; }
        }
    }
    public class Xylophone : Card
    {
        public override string Text
        {
            get { return "Xylophone"; }
        }

        public override double DifficultyModifier
        {
            get { return Card.DifficultyHard; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source1._1_Xylophone); }
        }

        public override string[] Groups
        {
            get { return new string[] { "Music","Toy" }; }
        }

        public override string[] MainColours
        {
            get { return new string[] { }; }
        }
    }
    public class Yacht : Card
    {
        public override string Text
        {
            get { return "Yacht"; }
        }

        public override double DifficultyModifier
        {
            get { return Card.DifficultyHard; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source1._1_Yacht); }
        }

        public override string[] Groups
        {
            get { return new string[] { "Boat" ,"Ocean"}; }
        }

        public override string[] MainColours
        {
            get { return new string[] { "Brown" }; }
        }
    }
    public class Zebra : Card
    {
        public override string Text
        {
            get { return "Zebra"; }
        }

        public override double DifficultyModifier
        {
            get { return Card.DifficultyBitHigh; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source1._1_Zebra); }
        }

        public override string[] Groups
        {
            get { return new string[] { "Animal" }; }
        }

        public override string[] MainColours
        {
            get { return new string[] { "White", "Black" }; }
        }
    }
}