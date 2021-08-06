from django.shortcuts import render
from django.views.generic import TemplateView 

class HomePageView(TemplateView):
    template_name = "index.html"

class AppPageView(TemplateView):
    template_name = "home.html"

class RegisterPageView(TemplateView):
    template_name = "register.html"

class AboutPageView(TemplateView):
    template_name = "about.html"

class RegisterApiPageView(TemplateView):
    template_name = "register_api.html"

class RegisterActionPageView(TemplateView):
    template_name = "register_action.html"