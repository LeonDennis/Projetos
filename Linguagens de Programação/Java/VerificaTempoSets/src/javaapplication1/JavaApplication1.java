/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package javaapplication1;

import java.util.Random;
import java.util.ArrayList;
import java.util.HashSet;
import java.util.LinkedHashSet;
import java.util.TreeSet;

/**
 *
 * @author usuario
 */
public class JavaApplication1 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) 
    {
        ArrayList(10000, 1);
        ArrayList(50000, 2);
        ArrayList(100000, 3);
        
        HashSet(10000, 1);
        HashSet(50000, 2);
        HashSet(100000, 3);
        
        LinkedHashSet(10000, 1);
        LinkedHashSet(50000, 2);
        LinkedHashSet(100000, 3);
        
        TreeSet(10000, 1);
        TreeSet(50000, 2);
        TreeSet(100000, 3);
    }
    
    private static Integer ArrayList(int insercoes, int num)
    {
        boolean aux;
        ArrayList <Integer> lista = new ArrayList();
        
        Cronometro.start();
        for (int i = 1; i < insercoes; i++) {lista.add(NumerosAleatorios());}
        Cronometro.stop();
        
        System.out.println("ArrayList " + num + ": Tempo gasto para " + insercoes + " inserções aleatórias");
        System.out.println("Iniciado as..: " + Cronometro.getInic());
        System.out.println("Finalizado as: " + Cronometro.getFim());
        System.out.println("Tempo total..: " + Cronometro.getTotal() + "ms");
        
        Cronometro.start();
        for (int i = 1; i < insercoes; ++i)
        {
            aux = lista.contains(i);
        }
        Cronometro.stop();
        
        System.out.println("Tempo gasto para " + insercoes + " verificações");
        System.out.println("Iniciado as..: " + Cronometro.getInic());
        System.out.println("Finalizado as: " + Cronometro.getFim());
        System.out.println("Tempo total..: " + Cronometro.getTotal() + "ms");
        System.out.println();
        return 0;
    }
    
    private static Integer HashSet(int insercoes, int num)
    {
        boolean aux;
        HashSet <Integer> lista = new HashSet();
        
        Cronometro.start();
        for (int i = 1; i < insercoes; i++) {lista.add(NumerosAleatorios());}
        Cronometro.stop();
        
        System.out.println("HashSet " + num + ": Tempo gasto para " + insercoes + " inserções aleatórias");
        System.out.println("Iniciado as..: " + Cronometro.getInic());
        System.out.println("Finalizado as: " + Cronometro.getFim());
        System.out.println("Tempo total..: " + Cronometro.getTotal() + "ms");
        
        Cronometro.start();
        for (int i = 1; i < insercoes; ++i)
        {
            aux = lista.contains(i);
        }
        Cronometro.stop();
        
        System.out.println("Tempo gasto para " + insercoes + " verificações");
        System.out.println("Iniciado as..: " + Cronometro.getInic());
        System.out.println("Finalizado as: " + Cronometro.getFim());
        System.out.println("Tempo total..: " + Cronometro.getTotal() + "ms");
        System.out.println();
        return 0;
    }
        
    private static Integer LinkedHashSet(int insercoes, int num)
    {
        boolean aux;
        LinkedHashSet <Integer> lista = new LinkedHashSet();
        
        Cronometro.start();
        for (int i = 1; i < insercoes; i++) {lista.add(NumerosAleatorios());}
        Cronometro.stop();
        
        System.out.println("LinkedHashSet " + num + ": Tempo gasto para " + insercoes + " inserções aleatórias");
        System.out.println("Iniciado as..: " + Cronometro.getInic());
        System.out.println("Finalizado as: " + Cronometro.getFim());
        System.out.println("Tempo total..: " + Cronometro.getTotal() + "ms");
        
        Cronometro.start();
        for (int i = 1; i < insercoes; ++i)
        {
            aux = lista.contains(i);
        }
        Cronometro.stop();
        
        System.out.println("Tempo gasto para " + insercoes + " verificações");
        System.out.println("Iniciado as..: " + Cronometro.getInic());
        System.out.println("Finalizado as: " + Cronometro.getFim());
        System.out.println("Tempo total..: " + Cronometro.getTotal() + "ms");
        System.out.println();
        return 0;
    }
            
    private static Integer TreeSet(int insercoes, int num)
    {
        boolean aux;
        TreeSet <Integer> lista = new TreeSet();
        
        Cronometro.start();
        for (int i = 1; i < insercoes; i++) {lista.add(NumerosAleatorios());}
        Cronometro.stop();
        
        System.out.println("TreeSet " + num + ": Tempo gasto para " + insercoes + " inserções aleatórias");
        System.out.println("Iniciado as..: " + Cronometro.getInic());
        System.out.println("Finalizado as: " + Cronometro.getFim());
        System.out.println("Tempo total..: " + Cronometro.getTotal() + "ms");
        
        Cronometro.start();
        for (int i = 1; i < insercoes; ++i)
        {
            aux = lista.contains(i);
        }
        Cronometro.stop();
        
        System.out.println("Tempo gasto para " + insercoes + " verificações");
        System.out.println("Iniciado as..: " + Cronometro.getInic());
        System.out.println("Finalizado as: " + Cronometro.getFim());
        System.out.println("Tempo total..: " + Cronometro.getTotal() + "ms");
        System.out.println();
        return 0;
    }
    
    private static Integer NumerosAleatorios()
    {
        int min = 1;
        int max = 200000;
        Random r = new Random();
        int a = r.nextInt(max-min) + min;
        return a;
    }
}
