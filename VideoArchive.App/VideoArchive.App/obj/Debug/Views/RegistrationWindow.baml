   M S B A M L   `   `   `  ����K  GVideoArchive.App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:VideoArchive.App.ViewsVideoArchive.App.Views  5   	   G(clr-namespace:VideoArchive.App.ViewModelVideoArchive.App.ViewModel  5   	   /    )VideoArchive.App.Views.RegistrationWindow   5   	   Z VDevExpress.Mvvm.UI, Version=18.2.0.0, Culture=neutral, PublicKeyToken=382ad28f6ae31f30R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:VideoArchive.App.Views     5   	   >	viewmodel(clr-namespace:VideoArchive.App.ViewModel     5   	     � 
ResizeMode$  NoResize=�5	   	    � WindowStartupLocation$ CenterScreen=�5
   	    � Icon$ Resources/main.png��5   
    � Title$ Регистрация��5   	   $	��450��6   $	��800��6*   .��5      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FFE5E5E8��6    � Offset$ 0.019Q�61   � 5      $ 	#FFC2E9FD��6   $ 1Q�61   5      .+�5   
   �  +� FocusedElement 6   �� 	 �� ElementName$	 loginTextBox��6R   �� 5   
      UserIcon#��[  5        IconContent#��[ 5      $��38,70,470.6,29q�5      5      �� 5#   
   $��25(�5$        MediumBaseBrush#��[ 5%      $
��Bold"�5&      $��Регистрация��5'      $��96,10,465.6,350q�6#   5(      � 5)   
   $��762,10,9.6,10q�6   ���	#FF236A856?   � 5*   
   $��10,391,9.6,10q�6   ���	#FF236A856?   �� 5+   
   $��380,42,323.6,179q�6   .+�5,      �� #��[ 5-      $��Логин:��5.      $��16(�5/      50      �� 51      #��[ 52      $��Пароль:��53      $��16(�54      $��0,20,0,0q�55      56      �� 57      #��[ 58      $��Имя:��59      $��16(�5:      $��0,20,0,0q�5;      5<      �� 5=      #��[ 5>      $��Фамилия:��5?      $��16(�5@      $��0,20,0,0q�5A      5B      5C      �� 5D   
   $��489,42,104.6,179q�6   .+�5F      �� -   5        
 ��Name$
 loginTextBox��5G      $��0,0,0,20q�5H      
 � Tag$	 ...��5I        BaseTextBox#��[ 5J      $��2q�5L      ��5K      �� *
LoginTmp+ �� UpdateSourceTrigger$ PropertyChanged=�5L      G� 5M      -   5        $��passw��5P      $��18(�5O      $��2q�5Q      $��0,0,-0.2,20q�5R      $��32��6&   �� 5Y      $	 ...��5Z      #��[ 5\      $��0,0,0,20q�5]      $��2q�5^      ��5[      �� *	FirstName+$ PropertyChanged=�5^      �� 5`      $	 ...��5a      #��[ 5b      $��2q�5d      ��5c      �� *
SecondName+$ PropertyChanged=�5d      5e      �� 5g   
     
BaseButton#��[ 5j      $��Сохранить��5k      $��395,280,280.6,72q�6#   ��5h      �� *Registration+5k   #   �� 5l   
   #��[ 5m      $��
Назад��5n      $��569,280,104.6,72q�5q      ��5o      �� *Back+��5p      ��  �� RelativeSource ��  �� Mode$ FindAncestor=� �� AncestorType" �5q      5s      5t      