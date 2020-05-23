import 'package:flutter/material.dart';

// Construtor Padrão
class DefaultList extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Container(
      padding: EdgeInsets.all(16),
      child: ListView(

        children: <Widget>[

          Icon(Icons.perm_identity, size: 60),
          Center(
            child: Text('Usuários Cadastrados', style: TextStyle(fontSize: 20))
          ),

          SizedBox(
            height: 20
          ),

          ListTile(
            leading: Icon(Icons.person),
            title: Text('Gandalf'),
            subtitle: Text('(99) 99999-9999'),
            trailing: Icon(Icons.edit),
            onTap: (){
              print('Clique padrão');
            },
            onLongPress: (){
              print('Clique Longo');
            }
          ),
          ListTile(
            leading: Icon(Icons.person),
            title: Text('Spock'),
            subtitle: Text('(99) 99999-9999'),
            trailing: Icon(Icons.edit),
            onTap: (){
              print('Clique padrão');
            },
            onLongPress: (){
              print('Clique Longo');
            }
          ),
          ListTile(
            leading: Icon(Icons.person),
            title: Text('Potter'),
            subtitle: Text('(99) 99999-9999'),
            trailing: Icon(Icons.edit),
            onTap: (){
              print('Clique padrão');
            },
            onLongPress: (){
              print('Clique Longo');
            }
          ),
          ListTile(
            leading: Icon(Icons.person),
            title: Text('Stark'),
            subtitle: Text('(99) 99999-9999'),
            trailing: Icon(Icons.edit),
            onTap: (){
              print('Clique padrão');
            },
            onLongPress: (){
              print('Clique Longo');
            }
          ),

          ExpansionTile(
            leading: Icon(Icons.person),
            title: Text('Stark'),
            subtitle: Text('(99) 99999-9999'),
            children: <Widget>[
              Text('Item 1'),
              Text('Item 2'),
              Text('Item 3')
            ]
          )

        ],

      )
    );
  }
}
