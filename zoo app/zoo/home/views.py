from django.shortcuts import render
#from django.http import HttpResponse
from django.http import HttpResponseRedirect
from . forms import RegistrationForm
from django.contrib.auth import login,authenticate
from django.shortcuts import redirect
from django.contrib import messages
from . forms import LoginForm
# Create your views here.
def index(request):
    return render(request,'pages/base.html')

def login(request):
    form=LoginForm()
    if request.method=="POST":
        form=LoginForm(request.POST)
        if form.is_valid():
            form.save()
            username=form.cleaned_data.get('username')
            password=form.cleaned_data.get('password')
    
           # username=request.POST["username"]
            #password=request.POST["password"]
        
            user=authenticate(username=username,password=password)
        if user is not None:
            if user.is_active:
                authenticate(request,user)
                return redirect('base')
        else:
            raise forms.ValidationError('Looks like a username or password is incorrect')
            return redirect('login')
    
        
    return render(request,'pages/login.html')
def logout(request):
    return render(request,'pages/logout.html')

def register(request):
    form=RegistrationForm()
    if request.method=="POST":
        form=RegistrationForm(request.POST)
        if form.is_valid():
            form.save()
            username=form.cleaned_data.get('username')
            email=form.cleaned_data.get('email')
            raw_password=form.cleaned_data.get('password1')
            if not(User.objects.filter(username=username).exists() or User.objects.filter(email=email).exists()):
                User.objects.create_user(username,email,pasword)
                user = authenticate(username=username, password=raw_password)
                login(request, user)
                message.success(rquest,f'Your account has been created for {username}!')
                if next:
                    return redirect(next)
                return HttpResponseRedirect('base')
            else:
                raise forms.ValidationError('Looks like a username with that email or password already exists')
    else:
        form=RegistrationForm()
    return render(request,'pages/register.html',{'form':form})

