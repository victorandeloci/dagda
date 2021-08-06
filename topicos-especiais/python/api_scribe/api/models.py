import mysql.connector

class Default:
    def __init__(self):
        self.db = mysql.connector.connect(
          host = 'localhost',
          user = 'root',
          password = '123',
          database = 'scribe'
        )

class Action(Default):

    def delete(self, action_id):
        super().__init__()

        cursor = self.db.cursor()
        cursor.execute('DELETE FROM action WHERE id = %s', (action_id,))

        self.db.commit()

        return (cursor.rowcount > 0)

    def createNew(self, name, api_id, path, parameters, response):
        super().__init__()

        cursor = self.db.cursor()
        cursor.execute('INSERT INTO action (name, api_id, path, parameters, response) VALUES (%s, %s, %s, %s, %s)', (name, api_id, path, parameters, response))

        self.db.commit()

        return (cursor.rowcount > 0)

    def getAllFromApi(self, api_id):
        super().__init__()

        cursor = self.db.cursor()
        cursor.execute('SELECT * FROM action WHERE api_id = %s', (api_id,))

        actions = []

        result = cursor.fetchall()
        if (len(result) > 0):
            for item in result:
                action = {
                    'id': item[0],
                    'name': item[1],
                    'path': item[3],
                    'parameters': item[4],
                    'response': item[5]
                }
                actions.append(action)

            return actions

class Api(Default):

    def delete(self, api_id):
        super().__init__()

        cursor = self.db.cursor()
        cursor.execute('DELETE FROM api WHERE id = %s', (api_id,))

        self.db.commit()

        return (cursor.rowcount > 0)

    def getAllFromUser(self, owner_id):
        super().__init__()

        cursor = self.db.cursor()
        cursor.execute('SELECT * FROM api WHERE owner_id = %s', (owner_id,))

        apis = []

        result = cursor.fetchall()
        if (len(result) > 0):
            for item in result:
                api = {
                    'id': item[0],
                    'name': item[1]
                }
                apis.append(api)

            return apis

    def createNew(self, name, owner_id):
        super().__init__()

        cursor = self.db.cursor()
        cursor.execute('INSERT INTO api (name, owner_id) VALUES (%s, %s)', (name, owner_id))

        self.db.commit()

        return (cursor.rowcount > 0)

class User(Default):

    def tryLogin(self, email, password):
        super().__init__()

        cursor = self.db.cursor()
        cursor.execute('SELECT * FROM user WHERE email = %s AND password = %s', (email, password))

        result = cursor.fetchall()

        if (len(result) > 0):
            self.id = result[0][0]
            self.email = result[0][1]
            self.password = result[0][2]

    def createNew(self, email, password):
        super().__init__()

        cursor = self.db.cursor()
        cursor.execute('INSERT INTO user (email, password) VALUES (%s, %s)', (email, password))

        self.db.commit()

        return (cursor.rowcount > 0)
