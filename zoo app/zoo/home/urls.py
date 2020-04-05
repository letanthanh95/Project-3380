from django.urls import path
from . import views
from django.contrib.staticfiles.urls import staticfiles_urlpatterns
from django.contrib.auth import views as auth_views
from django.contrib.auth.views import LoginView
from home import views as user_views
urlpatterns=[
    path('',views.index,name="home"),
    
    path('register/',user_views.register,name='register'),
    path('login/',auth_views.LoginView.as_view(template_name='pages/login.html'),name='login'),
    path('logout/',user_views.logout,{"next_page":"/"},name='logout')
    
]
urlpatterns += staticfiles_urlpatterns()