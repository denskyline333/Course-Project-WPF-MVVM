   M S B A M L   `   `   `  ����K  GVideoArchive.App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:VideoArchive.AppVideoArchive.App  5   	   ?$clr-namespace:VideoArchive.ViewModelVideoArchive.ViewModel  5   	   '    !VideoArchive.App.Views.AuthWindow   5   	   Z VDevExpress.Mvvm.UI, Version=18.2.0.0, Culture=neutral, PublicKeyToken=382ad28f6ae31f30R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:VideoArchive.App     5   	   :	viewmodel$clr-namespace:VideoArchive.ViewModel     5   	     � 
ResizeMode$  NoResize=�5	   	    � WindowStartupLocation$ CenterScreen=�5
   	    � Icon$ Resources/main.png��5   
    � Title$ Авторизация��5   	   $	��450��6   $	��400��6*   .��5      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FFE5E5E8��6    � Offset$ 0.019Q�61   � 5      $ 	#FFC2E9FD��6   $ 1Q�61   5      .+�5   
   �  +� FocusedElement 6   �� 	 �� ElementName$	 loginTextBox��6R   �� 5   
   $��Видео-архив��5      $��107,0,96.6,368q�5      $��25(�5         MediumBaseBrush#��[  5      $
��Bold"�5      5       �� 5!   
     	LoginIcon#��[ 5"      $��52,57,296.6,323q�5#      5$      �� 5%   
   -   5        
 ��Name$
 loginTextBox��5)        BaseTextBox#��[ 5&      $��97,57,96.6,323q�5*      $��2q�5+      ��5(      �� *Login+ �� UpdateSourceTrigger$ PropertyChanged=�.��5+   %   5,      �� 5-   
     PasswordIcon#��[ 5.      $��52,111,296.6,268q�5/      50      G� 59   
   -   5        $��passw��5<      $��18(�5;      $��2q�5=      $��97,111,96.6,268q�5>      5@      �� 5A   
     
BaseButton#��[ 5B      $��133,198,125.6,171q�5E      $��
Войти��5F      ��5C      �� *Auth+��5D      ��  �� RelativeSource ��  �� Mode$ FindAncestor=� �� AncestorType" �5F      �� 5G   
   #��[ 5H      $��133,274,125.6,103q�5J      $��Регистрация��5K      ��5I      �� *CreateRegistration+5K      5M      5N      