import 'package:flutter/material.dart';

void main(){
  runApp(
    MaterialApp(
      title: "App",

      //Nav routes
      initialRoute: "/home",
      routes: {
        "/home": (context) => Home(),
        "/firstPage": (context) => FirstPage(),
        "/secondPage": (context) => SecondPage()
      },

      //replaced by named routes
      //home: Home()

    )
  );
}

class Home extends StatelessWidget{
  @override
  Widget build(BuildContext context){
    return Scaffold(
      appBar: AppBar(
        title: Text("Home")
      ),
      body: Center(
        child: RaisedButton(
          child: Text("Abrir"),
          onPressed: (){

            Navigator.push(
              context,
              MaterialPageRoute(builder: (context) => FirstPage())
            );

          }
        )
      )
    );
  }
}

class FirstPage extends StatelessWidget{
  @override
  Widget build(BuildContext context){
    return Scaffold(
      appBar: AppBar(
        title: Text("Primeira Página")
      ),
      body: Center(
          child: Column(
              children: <Widget>[
                Padding(padding: EdgeInsets.only(top: 30)),
                RaisedButton(
                  child: Text("Segunda Página"),
                  onPressed: (){

                    Navigator.pushNamed(context, "/secondPage");

                    //replaced by named route

                    /*
                    Navigator.push(
                      context,
                      MaterialPageRoute(builder: (context) => SecondPage())
                    );
                    */

                  }
                ),
                RaisedButton(
                  child: Text("Voltar"),
                  onPressed: (){

                    Navigator.pop(context);

                  }
                )
              ]
          )
      )
    );
  }
}

class SecondPage extends StatelessWidget{
  @override
  Widget build(BuildContext context){
    return Scaffold(
      appBar: AppBar(
        title: Text("Segunda Página")
      ),
      body: Center(
        child: RaisedButton(
          child: Text("Voltar"),
          onPressed: (){

            Navigator.pop(context);

          }
        )
      )
    );
  }
}
