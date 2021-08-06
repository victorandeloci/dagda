from django.conf.urls import url
from app import views

urlpatterns = [
    url(r'^$', views.HomePageView.as_view(), name='home'),
    url(r'^app/$', views.AppPageView.as_view(), name='app'),
    url(r'^register/$', views.RegisterPageView.as_view(), name='register'),
    url(r'^about/$', views.AboutPageView.as_view(), name='about'),
    url(r'^register_api/$', views.RegisterApiPageView.as_view(), name='register_api'),
    url(r'^register_action/$', views.RegisterActionPageView.as_view(), name='register_action'),
]