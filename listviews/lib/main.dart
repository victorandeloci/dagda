import 'package:flutter/material.dart';

import 'defaultListView.dart';
import 'builderListView.dart';

void main() {
  runApp(Home());
}

class Home extends StatelessWidget {
  // This widget is the root of your application.
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      home: Scaffold(
        appBar: AppBar(title: Text('ListView')),
        //body: new DefaultList()
        body: new BuilderListView()
      )
    );
  }
}
