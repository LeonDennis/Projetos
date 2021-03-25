/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package javaapplication2;

import java.util.ArrayList;
import java.util.Collections;

/**
 *
 * @author Willmack
 */
public class JavaApplication2 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        ArrayList <Integer> lista = new ArrayList();
        for (int i = 1; i < 21; i++) {lista.add(Ex1());}
        
        System.out.println("20 números aleatórios: " + lista);
        Collections.sort(lista);
        System.out.println("Números aleatórios ordenados: " + lista);
        
        Ex2();
    }
    private static Integer Ex1() 
    {
        int a;
        a = (int)(Math.random()*100 + 1);
        return a;
    }
    private static String Ex2() 
    {
        System.out.println();
        ArrayList <String> lista1 = new ArrayList();
        lista1.add("A");
        lista1.add("B");
        lista1.add("Leon");
        lista1.add("C");
        lista1.add("D");
        lista1.add("E");
        
        ArrayList <String> listax = new ArrayList();
        lista1.add("Marli");
        lista1.add("Rubens");
        lista1.add("Maurício");
        
        System.out.println("Lista 1: " + lista1);
        System.out.println("Lista x: " + listax);
        
        lista1.addAll(listax);
        System.out.println("Lista combinada: " + lista1);
        return "";
    }
}