using System;

namespace QuebraCabeca.Console;

public static class Solucao
{
    public static List<int> EncontrarNumerosEscondidos(int A, int B, int C, int D, List<int> E)
    {
        return EncontrarNumerosEscondidosMaiorD( A, B, C, D, E);
    }

     public static List<int> EncontrarNumerosEscondidosMaiorIgualD(int A, int B, int C, int D, List<int> E)
    {
        List<int> resultado = [];
        
        for(int i = A; i<=B; i++ )
        {
            if(i % C != 0)
            {
                continue;
            }

            var iChars = i.ToString().ToCharArray();
            var somaDigitos =  iChars.Select(x => int.Parse(x.ToString())).Sum();

            if(somaDigitos < D)
            {
                continue;
            }
            
            bool contemChar = false;
           
            foreach(var c in iChars)
            {
                if(E.Contains(int.Parse(c.ToString())))
                {
                    contemChar = true;
                    break;
                }
            }
             
            if(contemChar == true)
            {
                continue;
            }
            
            resultado.Add(i);
        }
        return resultado;
    }

     public static List<int> EncontrarNumerosEscondidosMaiorD(int A, int B, int C, int D, List<int> E)
    {
        List<int> resultado = [];
        
        for(int i = A; i<=B; i++ )
        {
            if(i % C != 0)
            {
                continue;
            }

            var iChars = i.ToString().ToCharArray();
            var somaDigitos =  iChars.Select(x => int.Parse(x.ToString())).Sum();

            if(somaDigitos <= D)
            {
                continue;
            }
            
            bool contemChar = false;
           
            foreach(var c in iChars)
            {
                if(E.Contains(int.Parse(c.ToString())))
                {
                    contemChar = true;
                    break;
                }
            }
             
            if(contemChar == true)
            {
                continue;
            }
            
            resultado.Add(i);
        }
        return resultado;
    }
}
