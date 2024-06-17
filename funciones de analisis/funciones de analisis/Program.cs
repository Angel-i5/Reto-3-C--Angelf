// See https://aka.ms/new-console-template for more information
  
        Console.WriteLine("Por favor, ingresa un texto:");
        string texto = Console.ReadLine();

        int palabras = ContarPalabras(texto);
        int vocales = ContarVocales(texto);
        string textoInvertido = InvertirTexto(texto);

     
        Console.WriteLine("Número de palabras:" + palabras);
        Console.WriteLine("Número de vocales:" + vocales);
        Console.WriteLine("Texto invertido:" + textoInvertido);
    

    
     int ContarPalabras(string texto)
    {
     
        string[] palabras = texto.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        return palabras.Length;
    }

  
     int ContarVocales(string texto)
    {
        int contadorVocales = 0;
    string textoMin = texto.ToLower();

        foreach (char caracteres in textoMin)
        {
            if (EsVocal(caracteres))
            {
                contadorVocales++;
            }
        }

        return contadorVocales;
    }

    
     bool EsVocal(char caracter)
    {
        return "aeiou".Contains(caracter);
    }

    
     string InvertirTexto(string texto)
    {
        char[] caracteres = texto.ToCharArray();
        Array.Reverse(caracteres);
        return new string(caracteres);
    }


