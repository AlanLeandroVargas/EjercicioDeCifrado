//Cesar Cipher
string abc = "abcdefghijklmnñopqrstuvwxyz";
int displacement;
string plainText;
Console.WriteLine("Ingrese el texto plano");
plainText = Console.ReadLine().ToLower();
Console.WriteLine("Ingrese el numero de desplazamiento");
bool success = int.TryParse(Console.ReadLine(), out displacement);
if(!success){Console.WriteLine("Numero Invalido");}
Console.WriteLine(CesarCipher(plainText, displacement));
string CesarCipher(string plainText, int displacement)
{
    string displacedAbc = DisplaceAbc(displacement);
    string cipher = "";
    foreach(char letter in plainText)
    {
        cipher += displacedAbc[abc.IndexOf(letter)];
    }
    return cipher;
}

string DisplaceAbc(int displacement)
{
    string displacedLetters;
    string displacedAbc;    
    if(displacement > 0)
    {
        displacedLetters = abc.Substring(0, displacement);
        displacedAbc = abc.Substring(displacement);
        return displacedAbc + displacedLetters;
    }
    else
    {
        displacement = displacement + abc.Length;
        displacedLetters = abc.Substring(0, (displacement));
        displacedAbc = abc.Substring(displacement);
        return displacedAbc + displacedLetters;
    }    
}