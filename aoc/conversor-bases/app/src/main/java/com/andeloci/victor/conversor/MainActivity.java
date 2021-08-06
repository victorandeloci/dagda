package com.andeloci.victor.conversor;

import android.app.Activity;
import android.os.Build;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

public class MainActivity extends Activity {

    String baseInicial = "";

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        final Button hexaBtn = (Button) findViewById(R.id.hexaBtn);
        final Button decBtn = (Button) findViewById(R.id.decBtn);
        final Button octBtn = (Button) findViewById(R.id.octBtn);
        final Button binBtn = (Button) findViewById(R.id.binBtn);

        final EditText hexaTxt = findViewById(R.id.hexaTxt);
        final EditText decTxt = findViewById(R.id.decTxt);
        final EditText octTxt = findViewById(R.id.octTxt);
        final EditText binTxt = findViewById(R.id.binTxt);

        final Button btn0 = findViewById(R.id.btn0);
        final Button btn1 = findViewById(R.id.btn1);
        final Button btn2 = findViewById(R.id.btn2);
        final Button btn3 = findViewById(R.id.btn3);
        final Button btn4 = findViewById(R.id.btn4);
        final Button btn5 = findViewById(R.id.btn5);
        final Button btn6 = findViewById(R.id.btn6);
        final Button btn7 = findViewById(R.id.btn7);
        final Button btn8 = findViewById(R.id.btn8);
        final Button btn9 = findViewById(R.id.btn9);
        final Button btnA = findViewById(R.id.aBtn);
        final Button btnB = findViewById(R.id.bBtn);
        final Button btnC = findViewById(R.id.cBtn);
        final Button btnD = findViewById(R.id.dBtn);
        final Button btnE = findViewById(R.id.eBtn);
        final Button btnF = findViewById(R.id.fBtn);

        btnA.setEnabled(false);
        btnB.setEnabled(false);
        btnC.setEnabled(false);
        btnD.setEnabled(false);
        btnE.setEnabled(false);
        btnF.setEnabled(false);
        btn0.setEnabled(false);
        btn1.setEnabled(false);
        btn2.setEnabled(false);
        btn3.setEnabled(false);
        btn4.setEnabled(false);
        btn5.setEnabled(false);
        btn6.setEnabled(false);
        btn7.setEnabled(false);
        btn8.setEnabled(false);
        btn9.setEnabled(false);

        if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.LOLLIPOP) { // API 21
            hexaTxt.setShowSoftInputOnFocus(false);
            decTxt.setShowSoftInputOnFocus(false);
            octTxt.setShowSoftInputOnFocus(false);
            binTxt.setShowSoftInputOnFocus(false);
        } else { // API 11-20
            hexaTxt.setTextIsSelectable(true);
            decTxt.setTextIsSelectable(true);
            octTxt.setTextIsSelectable(true);
            binTxt.setTextIsSelectable(true);
        }

        hexaBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                acPress(v);
                hexaBtn.setBackgroundResource(R.drawable.button4_pressed);

                decBtn.setBackgroundResource(R.drawable.button4);
                octBtn.setBackgroundResource(R.drawable.button4);
                binBtn.setBackgroundResource(R.drawable.button4);

                hexaTxt.setEnabled(true);

                decTxt.setEnabled(false);
                octTxt.setEnabled(false);
                binTxt.setEnabled(false);

                baseInicial = "hexa";

                btnA.setEnabled(true);
                btnB.setEnabled(true);
                btnC.setEnabled(true);
                btnD.setEnabled(true);
                btnE.setEnabled(true);
                btnF.setEnabled(true);
                btn0.setEnabled(true);
                btn1.setEnabled(true);
                btn2.setEnabled(true);
                btn3.setEnabled(true);
                btn4.setEnabled(true);
                btn5.setEnabled(true);
                btn6.setEnabled(true);
                btn7.setEnabled(true);
                btn8.setEnabled(true);
                btn9.setEnabled(true);
            }
        });

        decBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                acPress(v);
                decBtn.setBackgroundResource(R.drawable.button4_pressed);

                hexaBtn.setBackgroundResource(R.drawable.button4);
                octBtn.setBackgroundResource(R.drawable.button4);
                binBtn.setBackgroundResource(R.drawable.button4);

                decTxt.setEnabled(true);

                hexaTxt.setEnabled(false);
                octTxt.setEnabled(false);
                binTxt.setEnabled(false);

                baseInicial = "dec";

                btnA.setEnabled(false);
                btnB.setEnabled(false);
                btnC.setEnabled(false);
                btnD.setEnabled(false);
                btnE.setEnabled(false);
                btnF.setEnabled(false);
                btn0.setEnabled(true);
                btn1.setEnabled(true);
                btn2.setEnabled(true);
                btn3.setEnabled(true);
                btn4.setEnabled(true);
                btn5.setEnabled(true);
                btn6.setEnabled(true);
                btn7.setEnabled(true);
                btn8.setEnabled(true);
                btn9.setEnabled(true);
            }
        });

        octBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                acPress(v);
                octBtn.setBackgroundResource(R.drawable.button4_pressed);

                hexaBtn.setBackgroundResource(R.drawable.button4);
                decBtn.setBackgroundResource(R.drawable.button4);
                binBtn.setBackgroundResource(R.drawable.button4);

                octTxt.setEnabled(true);

                decTxt.setEnabled(false);
                hexaTxt.setEnabled(false);
                binTxt.setEnabled(false);

                baseInicial = "oct";

                btnA.setEnabled(false);
                btnB.setEnabled(false);
                btnC.setEnabled(false);
                btnD.setEnabled(false);
                btnE.setEnabled(false);
                btnF.setEnabled(false);
                btn0.setEnabled(true);
                btn1.setEnabled(true);
                btn2.setEnabled(true);
                btn3.setEnabled(true);
                btn4.setEnabled(true);
                btn5.setEnabled(true);
                btn6.setEnabled(true);
                btn7.setEnabled(true);
                btn8.setEnabled(true);
                btn9.setEnabled(true);
            }
        });

        binBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                acPress(v);
                binBtn.setBackgroundResource(R.drawable.button4_pressed);

                decBtn.setBackgroundResource(R.drawable.button4);
                octBtn.setBackgroundResource(R.drawable.button4);
                hexaBtn.setBackgroundResource(R.drawable.button4);

                binTxt.setEnabled(true);

                decTxt.setEnabled(false);
                octTxt.setEnabled(false);
                hexaTxt.setEnabled(false);

                baseInicial = "bin";

                btnA.setEnabled(false);
                btnB.setEnabled(false);
                btnC.setEnabled(false);
                btnD.setEnabled(false);
                btnE.setEnabled(false);
                btnF.setEnabled(false);
                btn0.setEnabled(true);
                btn1.setEnabled(true);
                btn2.setEnabled(false);
                btn3.setEnabled(false);
                btn4.setEnabled(false);
                btn5.setEnabled(false);
                btn6.setEnabled(false);
                btn7.setEnabled(false);
                btn8.setEnabled(false);
                btn9.setEnabled(false);
            }
        });

    }

    public void CalcularBase(View view, String baseInicial, long valor, String hexaValor) {

        Conversor conv = new Conversor();

        long valorB10 = 0;

        EditText binTxt = findViewById(R.id.binTxt);
        EditText octTxt = findViewById(R.id.octTxt);
        EditText decTxt = findViewById(R.id.decTxt);
        EditText hexaTxt = findViewById(R.id.hexaTxt);

        //Teste de valor não preenchido e tamanho
        if(valor == 0 && hexaValor.equals("")){


        }
        //detecta a base selecionada
        else{

            try {

                //caso base Binária
                if (baseInicial.equals("bin")) {

                    valorB10 = Long.parseLong(conv.ConverterDecimal(valor, "", 2));

                    decTxt.setText(cleanString(String.valueOf(valorB10)));
                    octTxt.setText(cleanString(conv.ConverterOctal(valorB10)));
                    hexaTxt.setText(cleanString(conv.ConverterHexa(valorB10)));
                }
                //caso base Octal
                else if (baseInicial.equals("oct")) {

                    valorB10 = Long.parseLong(conv.ConverterDecimal(valor, "", 8));

                    decTxt.setText(cleanString(String.valueOf(valorB10)));
                    binTxt.setText(cleanString(conv.ConverterBinario(valorB10)));
                    hexaTxt.setText(cleanString(conv.ConverterHexa(valorB10)));
                }
                //caso base Decimal
                else if (baseInicial.equals("dec")) {

                    octTxt.setText(cleanString(conv.ConverterOctal(valor)));
                    binTxt.setText(cleanString(conv.ConverterBinario(valor)));
                    hexaTxt.setText(cleanString(conv.ConverterHexa(valor)));

                }
                //caso Hexadecimal
                else if (baseInicial.equals("hexa")) {

                    valorB10 = Long.parseLong(conv.ConverterDecimal(0, hexaValor, 16));

                    decTxt.setText(cleanString(String.valueOf(valorB10)));
                    binTxt.setText(cleanString(conv.ConverterBinario(valorB10)));
                    octTxt.setText(cleanString(conv.ConverterOctal(valorB10)));
                }
            }
            catch (NumberFormatException ex){

            }
        }
    }

    //formata a string para exibição
    private static String cleanString(String res) {
        res = res.replace(",", "");
        res = res.replace(" ", "");
        res = res.replace("[", "");
        res = res.replace("]", "");
        res = res.replace("|", "");
        res = res.replace("l", "");
        res = res.replace("u", "");
        res = res.replace("n", "");
        res = res.replace("un", "");
        res = res.replaceFirst("^0+(?!$)", "");

        return res;
    }

    public void KeyPress(View view){

       if (!(baseInicial.equals("") || baseInicial.isEmpty())){

            EditText txtbase = null;
            String value;

            switch (baseInicial){
                case "hexa":
                    txtbase = (EditText) findViewById(R.id.hexaTxt);
                    break;
                case "dec":
                    txtbase = (EditText) findViewById(R.id.decTxt);
                    break;
                case "oct":
                    txtbase = (EditText) findViewById(R.id.octTxt);
                    break;
                case "bin":
                    txtbase = (EditText) findViewById(R.id.binTxt);
            }

            switch (view.getId()){
                case R.id.aBtn:
                    txtbase.setText(txtbase.getText().toString() + "A");
                    break;
                case R.id.bBtn:
                    txtbase.setText(txtbase.getText().toString() + "B");
                    break;
                case R.id.cBtn:
                    txtbase.setText(txtbase.getText().toString() + "C");
                    break;
                case R.id.dBtn:
                    txtbase.setText(txtbase.getText().toString() + "D");
                    break;
                case R.id.eBtn:
                    txtbase.setText(txtbase.getText().toString() + "E");
                    break;
                case R.id.fBtn:
                    txtbase.setText(txtbase.getText().toString() + "F");
                    break;
                case R.id.btn0:
                    txtbase.setText(txtbase.getText().toString() + "0");
                    break;
                case R.id.btn1:
                    txtbase.setText(txtbase.getText().toString() + "1");
                    break;
                case R.id.btn2:
                    txtbase.setText(txtbase.getText().toString() + "2");
                    break;
                case R.id.btn3:
                    txtbase.setText(txtbase.getText().toString() + "3");
                    break;
                case R.id.btn4:
                    txtbase.setText(txtbase.getText().toString() + "4");
                    break;
                case R.id.btn5:
                    txtbase.setText(txtbase.getText().toString() + "5");
                    break;
                case R.id.btn6:
                    txtbase.setText(txtbase.getText().toString() + "6");
                    break;
                case R.id.btn7:
                    txtbase.setText(txtbase.getText().toString() + "7");
                    break;
                case R.id.btn8:
                    txtbase.setText(txtbase.getText().toString() + "8");
                    break;
                case R.id.btn9:
                    txtbase.setText(txtbase.getText().toString() + "9");
                    break;
                case R.id.apagarBtn:
                    String s = txtbase.getText().toString();
                    if (s.length() > 0) {
                        s = s.substring(0, s.length() - 1);
                    }
                    txtbase.setText(s);
                    break;
            }
        }
    }

    public void acPress(View view){
        EditText txtHexa = (EditText) findViewById(R.id.hexaTxt);
        EditText txtDec = (EditText) findViewById(R.id.decTxt);
        EditText txtOct = (EditText) findViewById(R.id.octTxt);
        EditText txtBin = (EditText) findViewById(R.id.binTxt);

        txtHexa.setText("");
        txtDec.setText("");
        txtOct.setText("");
        txtBin.setText("");
    }

    public void BtnConverter(View v){

        if (!(baseInicial.equals("") || baseInicial.isEmpty())){

            EditText hexaTxt = findViewById(R.id.hexaTxt);
            EditText decTxt = findViewById(R.id.decTxt);
            EditText octTxt = findViewById(R.id.octTxt);
            EditText binTxt = findViewById(R.id.binTxt);

            if(baseInicial.equals("")){

            }
            else if(baseInicial.equals("hexa")){
                if(!(hexaTxt.getText().toString().equals("") || hexaTxt.getText().toString().isEmpty()))
                    CalcularBase(v, baseInicial, 0, hexaTxt.getText().toString().toUpperCase());
            }
            else if(baseInicial.equals("dec")){
                if(!(decTxt.getText().toString().equals("") || decTxt.getText().toString().isEmpty()))
                    CalcularBase(v, baseInicial, Long.parseLong(decTxt.getText().toString()), "");
            }
            else if(baseInicial.equals("oct")){
                if(!(octTxt.getText().toString().equals("") || octTxt.getText().toString().isEmpty()))
                    CalcularBase(v, baseInicial, Long.parseLong(octTxt.getText().toString()), "");
            }
            else if(baseInicial.equals("bin")){
                if(!(binTxt.getText().toString().equals("") || binTxt.getText().toString().isEmpty()))
                    CalcularBase(v, baseInicial, Long.parseLong(binTxt.getText().toString()), "");
            }
        }
    }
}
