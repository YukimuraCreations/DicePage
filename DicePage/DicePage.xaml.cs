using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DicePage
{
    public void onDiceImage_Clicked(object sender, EventArgs e)
    {
        Random random = new Random();
        int randomNr = random.Next(1, 7);

        DiceImage.RotateTo(DiceImage.Rotation + 360);

        switch (randomNr)
        {
            case 1:
                DiceImage.Source = "one.png";
                break;
            case 2:
                DiceImage.Source = "two.png";
                break;
            case 3:
                DiceImage.Source = "three.png";
                break;
            case 4:
                DiceImage.Source = "four.png";
                break;
            case 5:
                DiceImage.Source = "five.png";
                break;
            case 6:
                DiceImage.Source = "six.png";
                break;
        }
    }
}