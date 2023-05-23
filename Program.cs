using System; //Biblioteca que permite a utilização do fucoes matematicas entre outras;
using System.Globalization; //Biblioteca que permite a convercao de um tipo de dado em outro, por exemplo de double para string;

namespace Course //Local do programa;
{
    public class program //Classe onde ficara o programa
    {
        public static void Main(string[] args) //Funcao principal do programa onde mostrara os resultados para o usuario;
        {
            double[] medidasX = LerMedidasTriangulo("X");  //Array que recebera os valores da array 'medidas' que é retornada pela Função LerMedidasTriangulo que recebe a  string "X";
            double[] medidasY = LerMedidasTriangulo("Y");  //Array que recebera os valores da array 'medidas' que é retornada pela Função LerMedidasTriangulo que recebe a  string "Y";

            double areaX = CalcularAreaTriangulo(medidasX);  // Variavel que recebe o valor da area retornado pela Função CalcularAreaTriangulo  utilizando como argumento a array medidasX;
            double areaY = CalcularAreaTriangulo(medidasY);  // Variavel que recebe o valor da area retornado pela Função CalcularAreaTriangulo  utilizando como argumento a array medidasX;

            Console.WriteLine("Area de X =" + areaX.ToString("F4", CultureInfo.InvariantCulture));  // mostra a area de X para o usuario converntendo seu valor para uma string e arrendondando seu valor para ate quatro numeros apos a virgula;
            Console.WriteLine("Area de Y =" + areaY.ToString("F4", CultureInfo.InvariantCulture));  // mostra a area de Y para o usuario converntendo seu valor para uma string e arrendondando seu valor para ate quatro numeros apos a virgula;

            if (areaX > areaY) //Caso a area de X seja maior que a de Y;
            {
                Console.WriteLine("Maior area: X"); //Relatar a area maior para o usuario;
            }
            else if (areaX < areaY)//Caso a area de X seja menor que a de Y;
            {
                Console.WriteLine("Maior area: Y");//Relatar a area maior para o usuario;
            }
            else //caso contrario;
            {
                Console.WriteLine("Areas iguais.");//Relatar  que as areas sao iguais para o usuario;
            }
        }


        public static double[] LerMedidasTriangulo(string nomeTriangulo) //Funcao que ira pedir e receber o tamanho dos lados do triangulo palo o usuario. A funcao retornara um array com valores double, e recebe uma string;
        {
            double[] medidas = new double[3]; //Criacao uma array que com 3 espacos para adicionar informacoes;

            Console.WriteLine("Entre as medidas do triangulo" + nomeTriangulo + ":"); //Interacao com o usuario pedindo a medida do triangulo
            for (int i = 0; i < 3; i++) // Para i comecando em 0 e adicionado 1 enquanto for menor que 3;
            {
                medidas[i] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture); // O valor digitado pelo usuario sera convertido em double e amarzenado na array medidas;
            }

            return medidas; //A funcao retornara a array medidas;
        }
        
        
        public static double CalcularAreaTriangulo(double[] medidas) //Funcao que ira fazer o calculo e retonar a area. Recebe como atributos uma array composta por doubles;
        {
            double a = medidas[0];  // varivel corresponde ao valor armazenado na posicao 0 da array medidas;
            double b = medidas[1];  // varivel corresponde ao valor armazenado na posicao 1 da array medidas;
            double c = medidas[2];  // varivel corresponde ao valor armazenado na posicao 2 da array medidas;

            double p = (a + b + c) / 2.0; //Calculo do p que é a metade do perimetro do triangulo e necessario para calcular a area;
            double area = Math.Sqrt(p * (p-a) * (p-b) * (p-c)); // Calculo da area;
            
            return area; //A funcao retornara o valor da area;
        }
    
    }
}