package com.andeloci.victor.conversor;

import java.util.Arrays;

public class Conversor {

    //conversor para Binário
    public String ConverterBinario(long num) {

        String res;
        long[] resu = new long[64];
        int i = 0;

        if(num == 0){
            return "0000000000000000";
        }
        else if(num == 1){
            return "0000000000000001";
        }
        else{
            do{

                resu[i] = num%2L;
                num = num / 2;
                i++;

            } while(num != 1);

            resu[i] = num;

            res = Arrays.toString(resu);
            res = reverse(res);

            return res;
        }

    }

    //conversor para Octal
    public String ConverterOctal(long num) {

        String res;
        long[] resu = new long[64];
        int i = 0;

        if(num == 0){
            return "0000000000000000";
        }
        else if(num == 1){
            return "0000000000000001";
        }
        else{
            do{

                resu[i] = num%8L;
                num = num / 8;
                i++;

            } while(num > 7);

            resu[i] = num;

            res = Arrays.toString(resu);
            res = reverse(res);

            return res;
        }

    }

    //conversor para Hexa
    public String ConverterHexa(long num) {

        String res;
        String[] resu = new String[64];
        int i = 0;

        if(num == 0){
            return "0000000000000000";
        }
        else if(num == 1){
            return "0000000000000001";
        }
        else{
            do{

                resu[i] = "" + (num%16);
                num = num / 16;
                i++;

            } while(num > 15);

            resu[i] = "" + num;

            for(int x = 0; x <= i; x++){

                switch(resu[x]){

                    case "10":
                        resu[x] = "A";
                        break;
                    case "11":
                        resu[x] = "B";
                        break;
                    case "12":
                        resu[x] = "C";
                        break;
                    case "13":
                        resu[x] = "D";
                        break;
                    case "14":
                        resu[x] = "E";
                        break;
                    case "15":
                        resu[x] = "F";
                        break;
                }
            }

            res = Arrays.toString(resu);
            res = reverse(res);

            return res;
        }

    }

    public String ConverterDecimal(long num, String numS, int base){

        long soma = 0;

        if(numS.equals("")){
            numS = String.valueOf(num);
        }

        String[] tempAlg = new String[numS.length()];
        int[] alg = new int[numS.length()];

        for (int i = 0; i < numS.length(); i++)
        {
            /*array(i) temporario recebe o valor, em string, do caractere na posiçao (i) da string invertida
                e faz a conversão caso haja letras*/
            tempAlg[i] = String.valueOf(reverse(numS).charAt(i));
            tempAlg[i] = unHex(tempAlg[i]);

            alg[i] = Integer.parseInt(tempAlg[i]);

            //array(i) recebe a função matemática (num * base**i)
            alg[i] = alg[i] * (int) (Math.pow(base, i));
            soma = soma + alg[i];
        }

        return String.valueOf(soma);
    }

    //inverte a string
    private String reverse(String input){
        char[] in = input.toCharArray();
        int begin=0;
        int end=in.length-1;
        char temp;
        while(end > begin){
            temp = in[begin];
            in[begin]=in[end];
            in[end] = temp;
            end--;
            begin++;
        }
        return new String(in);
    }

    private static String unHex(String valor){

        valor = valor.replace("A", "10");
        valor = valor.replace("B", "11");
        valor = valor.replace("C", "12");
        valor = valor.replace("D", "13");
        valor = valor.replace("E", "14");
        valor = valor.replace("F", "15");

        return valor;
    }

}

