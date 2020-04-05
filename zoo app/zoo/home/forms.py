from django import forms
import re
from django.contrib.auth.models import User
from django.core.exceptions import ObjectDoesNotExist
from django.contrib.auth.forms import AuthenticationForm
from django import forms
class RegistrationForm(forms.Form):
    username=forms.CharField(required =True,label="Username",widget=forms.TextInput(attrs={'class' : 'text w3lpass','autocomplete':'off'}))
    email=forms.EmailField(label="Email",widget=forms.TextInput(attrs={'class' : 'text w3lpass','autocomplete':'off'}))
    password1=forms.CharField(required =True,label="Password",widget=forms.PasswordInput(attrs={'class' : 'text w3lpass','autocomplete':'off'}))
    password2=forms.CharField(required =True,label="Confirm Password",widget=forms.PasswordInput(attrs={'class' : 'text w3lpass'}))
    class Meta:
        model=User
        fields = ('username', 'email' 'password1', 'password2', )
    def clean_password2(self):
        if 'password1' in self.cleaned_data:
            password1=self.cleaned_data['password1']
            password2=self.cleaned_data['password2']
            if password1==password2 and password1:
                return password2
        raise forms.ValidationError("Password and Confirm Password are not match")
    
    def clean_email(self):
        # Get the email
        email = self.cleaned_data.get('email')

        # Check to see if any users already exist with this email as a username.
        try:
            match = User.objects.get(email=email)
        except User.DoesNotExist:
            # Unable to find a user, this is fine
            return email

        # A user was found with this as a username, raise an error.
        raise forms.ValidationError('This email address is already in use.')

    def clean_username(self):
        username=self.cleaned_data['username']
        if not re.search(r'^\w+$',username):
            raise forms.ValidationError("Username Must Not Contain Special Characters")
        try:
            User.objects.get(username=username)
        except ObjectDoesNotExist:
            return username
        raise forms.ValidationError("Username is Existed")

    def save(self):
        User.objects.create_user(username=self.cleaned_data['username'],password=self.cleaned_data['password1'],email=self.cleaned_data['email'])


class LoginForm(forms.Form):
    username=forms.CharField(required =True,label="Username",widget=forms.TextInput(attrs={'autocomplete':'off'}))
    
    password=forms.CharField(required =True,label="Password",widget=forms.PasswordInput(attrs={'autocomplete':'off'}))
    class Meta:
        model=User
        fields = ('username','password', )
    def clean(self):
        username = self.cleaned_data['username']
        password = self.cleaned_data['password']
        user = authenticate(username=username, password=password)
        if not user or not user.is_active:
            raise forms.ValidationError("Sorry, that login was invalid. Please try again.")
        return self.cleaned_data

    def login(self, request):
        username = self.cleaned_data['username']
        password = self.cleaned_data['password']
        user = authenticate(username=username, password=password)
        return user