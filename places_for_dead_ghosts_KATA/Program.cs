using System.Linq;

String[] input = { "Artlu", "Breca", "Cityl", "Dedaf" };
char[] Earthenware = {'Q','U','T','H','C','R','D','M','Z'};
char[] Waterfall = {'W','E','V','O','X','I','N','G'};
char[] Fireplace = {'J','F','A','B','K','P','L','Y'};
char[] Windowsill = {'S'};

//For to iterate through each position
for (int i=0; i<input.Length; i++)
{
    //if verify in wich strategic position it should be set
    char first_char = input[i][0];
    if (Earthenware.Contains(first_char)) { }
    else if (Waterfall.Contains(first_char)) { }
    else if (Fireplace.Contains(first_char)) { }
    else if (Windowsill.Contains(first_char)) { }
    else { }
}

//if verify if the strategic position is empty or not
//empty? set the ghost there

//here's the problem, if the previous one is not empty we shall look for 
//the closest one from the strategic position

//return or console.print the array, by default the empty spaces should be '_____'

