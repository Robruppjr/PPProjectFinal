using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Room3Items 
{
    public Room3Items(){}
    
    public Room3Items(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public string Name { get; set; }
    
    public string Description { get; set;}


    // public string DresserRiddle { get; set; } = "Head to where you store important items that you use on a daily basis";
    // public string Mirror { get ; set ; } = "You begin to look around at the mirror and the plants surrounding it. You see a pothos, a spider plant, a cactus, and an orchid flower. As you look closer at the plants, you see a plant label sticking out of the orchid flower that has a capital ‘O’ on it. You inspect the other plants and see no other labels on them.";
    // public string MirrorRiddle { get; set; } = "“Head to where you see yourself as you are in the present moment”";
    // public string Bed { get ; set ; }= "You begin to inspect the bed, moving the blankets and pillows when you notice a tag sticking out of the pillowcase with a capital ‘W’ on it, followed by the brand. There is no other notable information found.";
    // public string BedRiddle { get; set; } = "“Head to where you spend a 1/4 of your day, everyday";
    // public string Chair { get ; set ; }= "You look around the chair and notice that there’s a letter ‘R’ stitched into the blanket. That must be a letter in the word!";

    // public string Door { get ; set ; }= "Enter password to the door:";
}