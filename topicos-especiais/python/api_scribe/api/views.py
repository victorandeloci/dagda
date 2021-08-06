from .models import *

from django.http import HttpResponse
import json
from django.views.decorators.csrf import csrf_exempt
import os
import zipfile

def index(request):
    return HttpResponse('Hello, world!')

@csrf_exempt
def login(request):
    response = {'status': False}

    if ('email' in request.POST and 'password' in request.POST):

        email = request.POST['email']
        password = request.POST['password']

        user = User()
        user.tryLogin(email, password)

        if (hasattr(user, 'id')):
            response['status'] = True
            response['content'] = {
                'id': user.id,
                'email': user.email
            }

    return HttpResponse(json.dumps(response))

@csrf_exempt
def register_user(request):
    response = {'status': False}

    if ('email' in request.POST and 'password' in request.POST):

        email = request.POST['email']
        password = request.POST['password']

        user = User()
        response['status'] = user.createNew(email, password)

    return HttpResponse(json.dumps(response))

@csrf_exempt
def register_api(request):
    response = {'status': False}

    if ('name' in request.POST and 'owner_id' in request.POST):

        name = request.POST['name']
        owner_id = request.POST['owner_id']

        api = Api()
        response['status'] = api.createNew(name, owner_id)

    return HttpResponse(json.dumps(response))

@csrf_exempt
def delete_api(request):
    response = {'status': False}

    if ('api_id' in request.POST):

        api_id = request.POST['api_id']

        api = Api()
        response['status'] = api.delete(api_id)

    return HttpResponse(json.dumps(response))

@csrf_exempt
def create_action(request):
    response = {'status': False}

    if ('name' in request.POST and 'api_id' in request.POST):

        name = request.POST['name']
        api_id = request.POST['api_id']

        path = ''
        parameters = ''
        apiResponse = ''

        if ('path' in request.POST):
            path = request.POST['path']

        if ('parameters' in request.POST):
            parameters = request.POST['parameters']

        if ('response' in request.POST):
            apiResponse = request.POST['response']

        action = Action()
        response['status'] = action.createNew(name, api_id, path, parameters, apiResponse)

    return HttpResponse(json.dumps(response))

@csrf_exempt
def delete_action(request):
    response = {'status': False}

    if ('action_id' in request.POST):

        action_id = request.POST['action_id']

        action = Action()
        response['status'] = action.delete(action_id)

    return HttpResponse(json.dumps(response))

@csrf_exempt
def get_apis(request):
    response = {'status': False}

    if ('owner_id' in request.GET):

        owner_id = request.GET['owner_id']

        api = Api()
        apis = api.getAllFromUser(owner_id)

        if (len(apis) > 0):
            response['status'] = True

            action = Action()
            for api in apis:
                api['actions'] = action.getAllFromApi(api['id'])

        response['content'] = apis

    return HttpResponse(json.dumps(response))

@csrf_exempt
def export_apis(request):
    response = {'status': False}

    if ('owner_id' in request.GET):

        owner_id = request.GET['owner_id']

        api = Api()
        apis = api.getAllFromUser(owner_id)

        if (len(apis) > 0):
            response['status'] = True

            action = Action()
            for api in apis:
                api['actions'] = action.getAllFromApi(api['id'])

        f = open('scribe_export.json', 'w')
        f.write(json.dumps(apis))
        f.close()

        zipfile.ZipFile('scribe_export.zip', mode='w').write('scribe_export.json')

        response = HttpResponse(open('scribe_export.zip', 'rb').read(), content_type='application/zip')
        response['Content-Disposition'] = 'inline; filename=scribe_export.zip'

    return response

@csrf_exempt
def export_html(request):

    if ('owner_id' in request.GET):

        owner_id = request.GET['owner_id']

        api = Api()
        apis = api.getAllFromUser(owner_id)

        if (len(apis) > 0):

            action = Action()
            for api in apis:
                api['actions'] = action.getAllFromApi(api['id'])

            content = ''
            for api in apis:
                content += '<h1>' + api['name'] + '</h1>'
                if(api['actions']):
                    for action in api['actions']:

                        content += (
                            '<div class="action-container">'
                                '<h3>' + action['name'] + '</h3>'
                                '<code>' + action['path'] + '</code>'
                                '<code>' + action['response'] + '</code>'
                            '</div>'
                        )

            html = (
                '<!DOCTYPE html>'
                '<html lang="en" dir="ltr">'
                  '<head>'
                    '<meta charset="utf-8">'
                    '<title>API Scribe</title>'

                    '<style media="screen">'

                    '</style>'

                  '</head>'
                  '<body>'
                    '<div class="container">' + content + '</div>'
                  '</body>'
                '</html>'
            )

            return HttpResponse(html)
