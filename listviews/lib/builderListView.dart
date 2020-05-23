import 'package:flutter/material.dart';

import 'item.dart';

//Construtor .builder
class BuilderListView extends StatefulWidget{
  @override
  BuilderListViewState createState() => BuilderListViewState();
}

class BuilderListViewState extends State<BuilderListView>{

  List<Item> list = [];

  Widget itemList(context, index){
    return Container(
      color: Color(0xFF000000),
      width: MediaQuery.of(context).size.width,
      padding: EdgeInsets.all(16),
      child: Card(
        color: Color(0xFF1a1a1a),
        child: Container(
          padding: EdgeInsets.all(16),
          child: Column(
            children: <Widget>[
              Image.network(list[index].imageSrc),
              Text(list[index].title, style: TextStyle(color: Colors.white, fontSize: 30, height: 2)),
              Text(list[index].subtitle, style: TextStyle(color: Colors.white, fontSize: 20, height: 2)),
              Text(list[index].info, style: TextStyle(color: Colors.white, height: 1.5)),
              SizedBox(height: 20),
              Row(
                mainAxisAlignment: MainAxisAlignment.center,
                children: <Widget>[
                  Icon(Icons.link, size: 32, color: Colors.white),
                  Icon(Icons.audiotrack, size: 32, color: Colors.white),
                  Icon(Icons.file_download, size: 32, color: Colors.white)
                ]
              )
            ]
          )
        )
      )
    );
  }

  @override
  Widget build(BuildContext context){

    list.add(Item('https://jpimg.com.br/uploads/2019/04/reprodu%C3%A7%C3%A3o_slash.jpg', 'Slash', 'Slash & Myles Kennedy', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam euismod faucibus elit ac tincidunt. Pellentesque bibendum placerat feugiat. Sed eu feugiat lectus. Nullam nec nulla tellus. Nunc nec augue ac turpis mollis pellentesque. Nulla sed condimentum augue. Fusce turpis quam, rhoncus nec mauris sed, pharetra feugiat odio.'));
    list.add(Item('https://jornaldebrasilia.com.br/wp-content/uploads/2020/05/axl-rose.jpg', 'Axl', 'GnR', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam euismod faucibus elit ac tincidunt. Pellentesque bibendum placerat feugiat. Sed eu feugiat lectus. Nullam nec nulla tellus. Nunc nec augue ac turpis mollis pellentesque. Nulla sed condimentum augue. Fusce turpis quam, rhoncus nec mauris sed, pharetra feugiat odio.'));
    list.add(Item('https://www.tenhomaisdiscosqueamigos.com/wp-content/uploads/2019/05/jack-black-game-thrones-1280x720.jpg', 'J. Black', 'Tenacious D', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam euismod faucibus elit ac tincidunt. Pellentesque bibendum placerat feugiat. Sed eu feugiat lectus. Nullam nec nulla tellus. Nunc nec augue ac turpis mollis pellentesque. Nulla sed condimentum augue. Fusce turpis quam, rhoncus nec mauris sed, pharetra feugiat odio.'));
    list.add(Item('https://4.bp.blogspot.com/-Ekuyk37Vubg/UypEbGNrCoI/AAAAAAAAHT4/7oegDxhxnC4/s1600/jimmypage.jpg', 'J. Page', 'Led Zeppelin', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam euismod faucibus elit ac tincidunt. Pellentesque bibendum placerat feugiat. Sed eu feugiat lectus. Nullam nec nulla tellus. Nunc nec augue ac turpis mollis pellentesque. Nulla sed condimentum augue. Fusce turpis quam, rhoncus nec mauris sed, pharetra feugiat odio.'));

    return Container(
      child: ListView.builder(
        scrollDirection: Axis.horizontal,
        itemCount: list.length,
        itemBuilder: itemList //widget para item da lista
      )
    );
  }
}
