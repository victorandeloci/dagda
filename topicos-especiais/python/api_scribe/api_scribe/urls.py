from django.contrib import admin
from django.conf.urls import url, include
from django.urls import path

urlpatterns = [
    url(r'^admin/', admin.site.urls),
    path('api/', include('api.urls')),
    url(r'^', include('app.urls')) 
]
