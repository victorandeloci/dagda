from django.urls import path
from . import views

urlpatterns = [
    path('', views.index, name = 'index'),
    path('login/', views.login, name = 'login'),
    path('register_user/', views.register_user, name = 'register_user'),
    path('register_api/', views.register_api, name = 'register_api'),
    path('create_action/', views.create_action, name = 'create_action'),
    path('get_apis/', views.get_apis, name = 'get_apis'),
    path('delete_api/', views.delete_api, name = 'delete_api'),
    path('delete_action/', views.delete_action, name = 'delete_action'),
    path('export_apis/', views.export_apis, name = 'export_apis'),
    path('export_html/', views.export_html, name = 'export_html')
]
