using System;
using System.Collections.Generic;
using System.Text;

namespace KiddyApp.Cards.Source2
{
    public class Antelope : Card
    {
        public override string Text
        {
            get { return "Antelope"; }
        }

        public override float DifficultyModifier
        {
            get { return Card.DifficultyHard; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source2._2_Antelope); }
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
    public class Apple : Card
    {
        public override string Text
        {
            get { return "Apple"; }
        }

        public override float DifficultyModifier
        {
            get { return Card.DifficulySomewhatEasy; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source2._2_Apple); }
        }

        public override string[] Groups
        {
            get { return new string[] { "Fruit","Food"}; }
        }

        public override string[] MainColours
        {
            get { return new string[] { "Red"}; }
        }
    }
    public class Barn : Card
    {
        public override string Text
        {
            get { return "Barn"; }
        }

        public override float DifficultyModifier
        {
            get { return Card.DifficulySomewhatEasy; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source2._2_Barn); }
        }

        public override string[] Groups
        {
            get { return new string[] {"Farm" }; }
        }

        public override string[] MainColours
        {
            get { return new string[] {"Red" }; }
        }
    }
    public class Bird : Card
    {
        public override string Text
        {
            get { return "Bird"; }
        }

        public override float DifficultyModifier
        {
            get { return Card.DifficulySomewhatEasy; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source2._2_Bird); }
        }

        public override string[] Groups
        {
            get { return new string[] { "Animal", "Sky" }; }
        }

        public override string[] MainColours
        {
            get { return new string[] {"Brown" }; }
        }
    }
    public class Camel : Card
    {
        public override string Text
        {
            get { return "Camel"; }
        }

        public override float DifficultyModifier
        {
            get { return Card.DifficulySomewhatEasy ; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source2._2_Camel); }
        }

        public override string[] Groups
        {
            get { return new string[] {"Animal" }; }
        }

        public override string[] MainColours
        {
            get { return new string[] {"Brown" }; }
        }
    }
    public class Cow : Card
    {
        public override string Text
        {
            get { return "Cow"; }
        }

        public override float DifficultyModifier
        {
            get { return Card.DifficultyEasy; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source2._2_Cow); }
        }

        public override string[] Groups
        {
            get { return new string[] { "Animal","Farm"}; }
        }

        public override string[] MainColours
        {
            get { return new string[] {"Whie","Brown" }; }
        }
    }
    public class Dinosaur : Card
    {
        public override string Text
        {
            get { return "Dinosaur"; }
        }

        public override float DifficultyModifier
        {
            get { return Card.DifficultyModerate; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source2._2_Dinosaur); }
        }

        public override string[] Groups
        {
            get { return new string[] {"Animal","Dinosaur" }; }
        }

        public override string[] MainColours
        {
            get { return new string[] { "Green"}; }
        }
    }
    public class Duck : Card
    {
        public override string Text
        {
            get { return "Duck"; }
        }

        public override float DifficultyModifier
        {
            get { return Card.DifficultyStandard; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source2._2_Duck); }
        }

        public override string[] Groups
        {
            get { return new string[] { "Animal", "Bird", "Farm", "Sky" }; }
        }

        public override string[] MainColours
        {
            get { return new string[] {"Yellow" }; }
        }
    }
    public class Eggs : Card
    {
        public override string Text
        {
            get { return "Eggs"; }
        }

        public override float DifficultyModifier
        {
            get { return Card.DifficultyStandard; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source2._2_Eggs); }
        }

        public override string[] Groups
        {
            get { return new string[] {"Food","Kitchen","Farm"}; }
        }

        public override string[] MainColours
        {
            get { return new string[] { "White"}; }
        }
    }
    public class Elephant : Card
    {
        public override string Text
        {
            get { return "Elephant"; }
        }

        public override float DifficultyModifier
        {
            get { return Card.DifficultyBitHigh; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source2._2_Elephant); }
        }

        public override string[] Groups
        {
            get { return new string[] {"Animal" }; }
        }

        public override string[] MainColours
        {
            get { return new string[] {"Purple" }; }
        }
    }
    public class Flamingo : Card
    {
        public override string Text
        {
            get { return "Flamingo"; }
        }

        public override float DifficultyModifier
        {
            get { return Card.DifficultyBitHigh; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source2._2_Flamingo); }
        }

        public override string[] Groups
        {
            get { return new string[] { "Animal", "Bird", "Sky" }; }
        }

        public override string[] MainColours
        {
            get { return new string[] {"Pink" }; }
        }
    }
    public class Giraffe : Card
    {
        public override string Text
        {
            get { return "Giraffe"; }
        }

        public override float DifficultyModifier
        {
            get { return Card.DifficultyStandard; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source2._2_Giraffe); }
        }

        public override string[] Groups
        {
            get { return new string[] {"Animal" }; }
        }

        public override string[] MainColours
        {
            get { return new string[] {"Yellow" }; }
        }
    }
    public class Goats : Card
    {
        public override string Text
        {
            get { return "Goats"; }
        }

        public override float DifficultyModifier
        {
            get { return Card.DifficultyStandard; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source2._2_Goats); }
        }

        public override string[] Groups
        {
            get { return new string[] {"Animal","Farm" }; }
        }

        public override string[] MainColours
        {
            get { return new string[] { "Yellow"}; }
        }
    }
    public class Horse : Card
    {
        public override string Text
        {
            get { return "Horse"; }
        }

        public override float DifficultyModifier
        {
            get { return Card.DifficultyStandard; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source2._2_Horse); }
        }

        public override string[] Groups
        {
            get { return new string[] { "Animal","Farm"}; }
        }

        public override string[] MainColours
        {
            get { return new string[] {"Brown" }; }
        }
    }
    public class House : Card
    {
        public override string Text
        {
            get { return "House"; }
        }

        public override float DifficultyModifier
        {
            get { return Card.DifficultyStandard; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source2._2_House); }
        }

        public override string[] Groups
        {
            get { return new string[] { "Home"}; }
        }

        public override string[] MainColours
        {
            get { return new string[] {"Cream" }; }
        }
    }
    public class Igloo : Card
    {
        public override string Text
        {
            get { return "Igloo"; }
        }

        public override float DifficultyModifier
        {
            get { return Card.DifficultyBitHigh; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source2._2_Igloo); }
        }

        public override string[] Groups
        {
            get { return new string[] {"Cold","Home" }; }
        }

        public override string[] MainColours
        {
            get { return new string[] { "White"}; }
        }
    }
    public class Insect : Card
    {
        public override string Text
        {
            get { return "Insect"; }
        }

        public override float DifficultyModifier
        {
            get { return Card.DifficultyBitHigh; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source2._2_Insect); }
        }

        public override string[] Groups
        {
            get { return new string[] {"Animal" }; }
        }

        public override string[] MainColours
        {
            get { return new string[] { }; }
        }
    }
    public class Jacket : Card
    {
        public override string Text
        {
            get { return "Jacket"; }
        }

        public override float DifficultyModifier
        {
            get { return Card.DifficultyBitHigh; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source2._2_Jacket); }
        }

        public override string[] Groups
        {
            get { return new string[] {"Clothes" }; }
        }

        public override string[] MainColours
        {
            get { return new string[] {"Yellow" }; }
        }
    }
    public class JesterHat : Card
    {
        public override string Text
        {
            get { return "Jester Hat"; }
        }

        public override float DifficultyModifier
        {
            get { return Card.DifficultyHard; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source2._2_Jester_Hat); }
        }

        public override string[] Groups
        {
            get { return new string[] {"Clothes" }; }
        }

        public override string[] MainColours
        {
            get { return new string[] { "Purple","Blue"}; }
        }
    }
    public class Kite : Card
    {
        public override string Text
        {
            get { return "Kite"; }
        }

        public override float DifficultyModifier
        {
            get { return Card.DifficultyStandard; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source2._2_Kite); }
        }

        public override string[] Groups
        {
            get { return new string[] {"Outside" }; }
        }

        public override string[] MainColours
        {
            get { return new string[] {"Red","Yellow","Green","Pink" }; }
        }
    }
    public class Kitten : Card
    {
        public override string Text
        {
            get { return "Kitten"; }
        }

        public override float DifficultyModifier
        {
            get { return Card.DifficulySomewhatEasy; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source2._2_Kitten); }
        }

        public override string[] Groups
        {
            get { return new string[] {"Animal" }; }
        }

        public override string[] MainColours
        {
            get { return new string[] {"Yellow" }; }
        }
    }
    public class Lamb : Card
    {
        public override string Text
        {
            get { return "Lamb"; }
        }

        public override float DifficultyModifier
        {
            get { return Card.DifficulySomewhatEasy; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source2._2_Lamb); }
        }

        public override string[] Groups
        {
            get { return new string[] {"Farm","Animal" }; }
        }

        public override string[] MainColours
        {
            get { return new string[] { "White"}; }
        }
    }
    public class Lion : Card
    {
        public override string Text
        {
            get { return "Lion"; }
        }

        public override float DifficultyModifier
        {
            get { return Card.DifficultyStandard; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source2._2_Lion); }
        }

        public override string[] Groups
        {
            get { return new string[] {"Animal" }; }
        }

        public override string[] MainColours
        {
            get { return new string[] { "Brown"}; }
        }
    }
    public class Monkey : Card
    {
        public override string Text
        {
            get { return "Monkey"; }
        }

        public override float DifficultyModifier
        {
            get { return Card.DifficultyStandard; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source2._2_Monkey); }
        }

        public override string[] Groups
        {
            get { return new string[] { "Animal"}; }
        }

        public override string[] MainColours
        {
            get { return new string[] { "Brown"}; }
        }
    }
    public class Moose : Card
    {
        public override string Text
        {
            get { return "Moose"; }
        }

        public override float DifficultyModifier
        {
            get { return Card.DifficultyBitHigh; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source2._2_Moose); }
        }

        public override string[] Groups
        {
            get { return new string[] { "Animal"}; }
        }

        public override string[] MainColours
        {
            get { return new string[] {"Brown" }; }
        }
    }
    public class Notes : Card
    {
        public override string Text
        {
            get { return "Notes"; }
        }

        public override float DifficultyModifier
        {
            get { return Card.DifficultyModerate; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source2._2_Notes); }
        }

        public override string[] Groups
        {
            get { return new string[] {"Music" }; }
        }

        public override string[] MainColours
        {
            get { return new string[] {"Black" }; }
        }
    }
    public class Numbers : Card
    {
        public override string Text
        {
            get { return "Numbers"; }
        }

        public override float DifficultyModifier
        {
            get { return Card.DifficultyBitHigh; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source2._2_Numbers); }
        }

        public override string[] Groups
        {
            get { return new string[] { }; }
        }

        public override string[] MainColours
        {
            get { return new string[] {"White" }; }
        }
    }
    public class Octopus : Card
    {
        public override string Text
        {
            get { return "Octopus"; }
        }

        public override float DifficultyModifier
        {
            get { return Card.DifficultyStandard; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source2._2_Octopus); }
        }

        public override string[] Groups
        {
            get { return new string[] { "Animal","Ocean"}; }
        }

        public override string[] MainColours
        {
            get { return new string[] {"Purple" }; }
        }
    }
    public class Owls : Card
    {
        public override string Text
        {
            get { return "Owls"; }
        }

        public override float DifficultyModifier
        {
            get { return Card.DifficultyStandard; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source2._2_Owls); }
        }

        public override string[] Groups
        {
            get { return new string[] { "Animal", "Sky" }; }
        }

        public override string[] MainColours
        {
            get { return new string[] {"Brown" }; }
        }
    }
    public class Paint : Card
    {
        public override string Text
        {
            get { return "Paint"; }
        }

        public override float DifficultyModifier
        {
            get { return Card.DifficultyStandard; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source2._2_Paint); }
        }

        public override string[] Groups
        {
            get { return new string[] { }; }
        }

        public override string[] MainColours
        {
            get { return new string[] {"Yellow","Blue" }; }
        }
    }
    public class Pumpkin : Card
    {
        public override string Text
        {
            get { return "Pumpkin"; }
        }

        public override float DifficultyModifier
        {
            get { return Card.DifficultyBitHigh; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source2._2_Pumpkin); }
        }

        public override string[] Groups
        {
            get { return new string[] { "Fruit","Food","Plant"}; }
        }

        public override string[] MainColours
        {
            get { return new string[] {"Yellow" ,"Orange"}; }
        }
    }
    public class Rocket : Card
    {
        public override string Text
        {
            get { return "Rocket"; }
        }

        public override float DifficultyModifier
        {
            get { return Card.DifficultyBitHigh; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source2._2_Rocket); }
        }

        public override string[] Groups
        {
            get { return new string[] { "Sky" }; }
        }

        public override string[] MainColours
        {
            get { return new string[] { "Orange"}; }
        }
    }
    public class RockingHorse : Card
    {
        public override string Text
        {
            get { return "Rocking Horse"; }
        }

        public override float DifficultyModifier
        {
            get { return Card.DifficultyStandard; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source2._2_Rocking_Horse); }
        }

        public override string[] Groups
        {
            get { return new string[] { "Toy"}; }
        }

        public override string[] MainColours
        {
            get { return new string[] { "Purple"}; }
        }
    }
    public class Snake : Card
    {
        public override string Text
        {
            get { return "Snake"; }
        }

        public override float DifficultyModifier
        {
            get { return Card.DifficultyStandard; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source2._2_Snake); }
        }

        public override string[] Groups
        {
            get { return new string[] { "Animal"}; }
        }

        public override string[] MainColours
        {
            get { return new string[] {"Green" }; }
        }
    }
    public class Stars : Card
    {
        public override string Text
        {
            get { return "Stars"; }
        }

        public override float DifficultyModifier
        {
            get { return Card.DifficulySomewhatEasy ; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source2._2_Stars); }
        }

        public override string[] Groups
        {
            get { return new string[] { "Sky" }; }
        }

        public override string[] MainColours
        {
            get { return new string[] { "Red","Blue"}; }
        }
    }
    public class Tree : Card
    {
        public override string Text
        {
            get { return "Tree"; }
        }

        public override float DifficultyModifier
        {
            get { return Card.DifficulySomewhatEasy ; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source2._2_Tree); }
        }

        public override string[] Groups
        {
            get { return new string[] { "Plant"}; }
        }

        public override string[] MainColours
        {
            get { return new string[] { "Brown","Green"}; }
        }
    }
    public class Turtle : Card
    {
        public override string Text
        {
            get { return "Turtle"; }
        }

        public override float DifficultyModifier
        {
            get { return Card.DifficultyBitHigh; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source2._2_Turtle); }
        }

        public override string[] Groups
        {
            get { return new string[] {"Animal" }; }
        }

        public override string[] MainColours
        {
            get { return new string[] {"Green","Brown" }; }
        }
    }
    public class Umbrella : Card
    {
        public override string Text
        {
            get { return "Umbrella"; }
        }

        public override float DifficultyModifier
        {
            get { return Card.DifficultyBitHigh; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source2._2_Umbrella); }
        }

        public override string[] Groups
        {
            get { return new string[] { }; }
        }

        public override string[] MainColours
        {
            get { return new string[] { "Red"}; }
        }
    }
    public class Unicorn : Card
    {
        public override string Text
        {
            get { return "Unicorn"; }
        }

        public override float DifficultyModifier
        {
            get { return Card.DifficultyBitHigh; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source2._2_Unicorn); }
        }

        public override string[] Groups
        {
            get { return new string[] {"Animal" }; }
        }

        public override string[] MainColours
        {
            get { return new string[] { "White","Purple"}; }
        }
    }
    public class Violin : Card
    {
        public override string Text
        {
            get { return "Violin"; }
        }

        public override float DifficultyModifier
        {
            get { return Card.DifficultyBitHigh; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source2._2_Violin); }
        }

        public override string[] Groups
        {
            get { return new string[] { "Music", "Musical Instrument" }; }
        }

        public override string[] MainColours
        {
            get { return new string[] {"Brown" }; }
        }
    }
    public class Volcano : Card
    {
        public override string Text
        {
            get { return "Volcano"; }
        }

        public override float DifficultyModifier
        {
            get { return Card.DifficultyModerate; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source2._2_Volcano); }
        }

        public override string[] Groups
        {
            get { return new string[] { }; }
        }

        public override string[] MainColours
        {
            get { return new string[] {"Brown","Green","Red","Grey" }; }
        }
    }
    public class Watermellon : Card
    {
        public override string Text
        {
            get { return "Watermellon"; }
        }

        public override float DifficultyModifier
        {
            get { return Card.DifficultyStandard; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source2._2_Watermellon); }
        }

        public override string[] Groups
        {
            get { return new string[] {"Fruit","Food","Plant" }; }
        }

        public override string[] MainColours
        {
            get { return new string[] {"Green","Red" }; }
        }
    }
    public class Whale : Card
    {
        public override string Text
        {
            get { return "Whale"; }
        }

        public override float DifficultyModifier
        {
            get { return Card.DifficultyBitHigh; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source2._2_Whale); }
        }

        public override string[] Groups
        {
            get { return new string[] {"Animal","Ocean" }; }
        }

        public override string[] MainColours
        {
            get { return new string[] { "Blue"}; }
        }
    }
    public class XRay : Card
    {
        public override string Text
        {
            get { return "X Ray"; }
        }

        public override float DifficultyModifier
        {
            get { return Card.DifficultyHard; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source2._2_X_Ray); }
        }

        public override string[] Groups
        {
            get { return new string[] { }; }
        }

        public override string[] MainColours
        {
            get { return new string[] { "Black"}; }
        }
    }
    public class Xylophone : Card
    {
        public override string Text
        {
            get { return "Xylophone"; }
        }

        public override float DifficultyModifier
        {
            get { return Card.DifficultyModerate; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source2._2_Xylophone); }
        }

        public override string[] Groups
        {
            get { return new string[] { "Music", "Toy", "Musical Instrument" }; }
        }

        public override string[] MainColours
        {
            get { return new string[] { }; }
        }
    }
    public class Yarn : Card
    {
        public override string Text
        {
            get { return "Yarn"; }
        }

        public override float DifficultyModifier
        {
            get { return Card.DifficultyBitHigh; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source2._2_Yarn); }
        }

        public override string[] Groups
        {
            get { return new string[] { }; }
        }

        public override string[] MainColours
        {
            get { return new string[] {"Pink" }; }
        }
    }
    public class YoYo : Card
    {
        public override string Text
        {
            get { return "YoYo"; }
        }

        public override float DifficultyModifier
        {
            get { return Card.DifficultyStandard; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source2._2_Yoyo); }
        }

        public override string[] Groups
        {
            get { return new string[] {"Toy" }; }
        }

        public override string[] MainColours
        {
            get { return new string[] { "Blue"}; }
        }
    }
    public class Zebra : Card
    {
        public override string Text
        {
            get { return "Zebra"; }
        }

        public override float DifficultyModifier
        {
            get { return Card.DifficultyBitHigh; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source2._2_Zebra); }
        }

        public override string[] Groups
        {
            get { return new string[] {"Animal" }; }
        }

        public override string[] MainColours
        {
            get { return new string[] { "White","Black"}; }
        }
    }
    public class Zipper : Card
    {
        public override string Text
        {
            get { return "Zipper"; }
        }

        public override float DifficultyModifier
        {
            get { return Card.DifficultyStandard; }
        }

        public override System.Drawing.Image Image
        {
            get { return new System.Drawing.Bitmap(Images.Source2._2_Zipper); }
        }

        public override string[] Groups
        {
            get { return new string[] { }; }
        }

        public override string[] MainColours
        {
            get { return new string[] {"Blue" }; }
        }
    }
}
