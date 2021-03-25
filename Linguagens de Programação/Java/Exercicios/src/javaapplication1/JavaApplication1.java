
package javaapplication1;
import java.util.Scanner;

public class JavaApplication1 
{
    public static void main(String[] args) 
    {
        int opcao;
        do
        {
            System.out.println("Digite a opção desejada: ");
            System.out.println("1 - Conversão de Celsius para Graus");
            System.out.println("2 - Calcular a média aritmética de notas");
            System.out.println("3 - Calcular a média geomética de valores");
            System.out.println("4 - Quantos dias tem em um certo mês");
            System.out.println("5 - Sair");
        
            Scanner sc = new Scanner(System.in);
            opcao = sc.nextInt();
        
            switch(opcao)
            {
                case 1:
                    int temp;
                    System.out.println("Digite a temperatura em Celsius: ");
                    temp = sc.nextInt();
                    System.out.println("Temperatura: " + ((temp * 1.8)+ 32) + " Fahrenheit");
                    break;
                
                case 2:
                    float media = 0;
                    for (int i = 1; i < 5; i++)
                    {
                        System.out.println("Digite a " + i + "ª " + "nota");
                        media += sc.nextInt();
                    }
                    System.out.println("Média aritmética das notas dadas: " + (media / 4));
                    if( (media >= 3) && (media <6) ){System.out.println("O aluno está de exame;");} 
                    else if(media < 3){System.out.println("O aluno foi reprovado.");} 
                    else if(media >= 7){System.out.println("O aluno foi aprovado.");}
                    break;
                
                case 3:
                    double valor = 1.0;
                    double valortemp;
                    for (int i = 1; i < 5; i++)
                    {
                        System.out.println("Digite o " + i + "ª " + "valor");
                        valortemp = sc.nextInt();
                        valor = valortemp * valor;
                    }
                    System.out.println("Média geométrica dos valores dados: " + java.lang.Math.pow(valor, 1.0 / 4.0));
                    break;
                
                case 4:
                    int mes, dias=31;
                    System.out.println("Digite o mês [1-12]: ");
                    mes = sc.nextInt();
        
                    if(mes>12 || mes<1)
                    {
                        System.out.println("Mês inválido");
                        return;
                    }
                    switch(mes)
                    {
                        case 2: 
                        dias -=2;
                        
                        case 4: case 6: case 9: case 11:
                        dias--;
                    }
                    System.out.printf("O mês %d possui %d dias.", mes, dias);
                    break;
            }
        } while (opcao != 5);
    }  
}
