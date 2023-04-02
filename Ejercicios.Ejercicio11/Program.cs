using System;

Console.WriteLine("ingrese una frase.");
string frase = Console.ReadLine();
string frasenueva = "";
foreach (char letra in frase)
{
    switch (letra)
    {
        case 'á':
            frasenueva = frasenueva + 'a';
            break;
        case 'é':
            frasenueva = frasenueva + 'e';
            break;
        case 'í':
            frasenueva = frasenueva + 'i';
            break;
        case 'ó':
            frasenueva = frasenueva + 'o';
            break;
        case 'ú':
            frasenueva = frasenueva + 'u';
            break;
        default:
            frasenueva = frasenueva + letra;
            break;

    }
}

Console.WriteLine("La frase con letras sin acentos es: " + frasenueva);