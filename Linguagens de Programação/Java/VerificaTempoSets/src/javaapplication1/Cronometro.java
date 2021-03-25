/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package javaapplication1;

import java.util.Date;
import java.text.SimpleDateFormat;
/**
 *
 * @author Mauricio
 */
public class Cronometro {
    private static Date inic, fim;
    
    public static void start() {inic = new Date();}
    public static void stop()  {fim = new Date();}
    
    public static String getInic()
    {
        SimpleDateFormat formatohora = new SimpleDateFormat("HH:mm:ss:SS");
        return formatohora.format(inic);
    }

    public static String getFim()
    {
        SimpleDateFormat formatohora = new SimpleDateFormat("HH:mm:ss:SS");
        return formatohora.format(fim);
    }
    
    public static long getTotal() {return fim.getTime() - inic.getTime();}
    
}
