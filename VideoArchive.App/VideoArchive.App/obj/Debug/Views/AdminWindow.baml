   M S B A M L   `   `   `  ����K  GVideoArchive.App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:VideoArchive.App.ViewsVideoArchive.App.Views  5   	   ?$clr-namespace:VideoArchive.ViewModelVideoArchive.ViewModel  5   	   G(clr-namespace:VideoArchive.App.ViewModelVideoArchive.App.ViewModel  5   	   (    "VideoArchive.App.Views.AdminWindow   5   	   Z VDevExpress.Mvvm.UI, Version=18.2.0.0, Culture=neutral, PublicKeyToken=382ad28f6ae31f30R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:VideoArchive.App.Views     5   	   :	viewmodel$clr-namespace:VideoArchive.ViewModel     5   	   ?
viewmodel1(clr-namespace:VideoArchive.App.ViewModel     5   	     � WindowStartupLocation$  CenterScreen=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � Icon$ Resources/main.png��5   	    � Title$+ %Окно администратора��5   	   $	��450��6%   $	��800��62    � DataContext 5      /  )VideoArchive.App.ViewModel.AdminViewModel  5   
    � 	Resources 5         DGHeaderStyle �� 
TargetType&   System.Windows.Controls.DataGrid �� Property  DGCHeaderStyle �� Value=  7System.Windows.Controls.Primitives.DataGridColumnHeader��%N  &	        &	 X     �� 5   
   "  6&   .�5      ��  �@ ColumnHeaderStyle# �  62   5      �� 5   
   "  6'   .�5      ��  � ��$ 30��6'   �� 5       � ��
 ��ح�6+   �� 5       � ��
 �   �6+   �� 5       � ��$ 18(�6)   �� 5       � ��$ DemiBold"�6+   5      5      .��5      � ��5   
   �� 5      	 �� EndPoint$	 0.5,1&�6"   
 �� 
StartPoint$
 0.5,0&�63   .��5       �  � Color$ 	#FFE5E5E8��6    � Offset$ 0.019Q�61   � 5!      $ 	#FFC2E9FD��6   $ 1Q�61   5"       � RowDefinitions 5$   
   �� 5%      $��* �6   �� 5&      $
��Auto �6   .+�5(   
   ��   	AdminIcon#��[ 6   $��0,0,465.6,96q�6>   5*      �� 5+   
   $��25(�5,        MediumBaseBrush#��[ 5-      $
��Bold"�5.      $��Пользователи��5/      $��481,0,113.6,375q�6$   50      �� 51   
   $��25(�52      #��[ 53      $
��Bold"�54      $ ��Администратор��55      $��60,329,465.6,23q�6%   56        5;   
   -   5          Name$ 	usersGrid��5<         AutoGenerateColumns .     	RowHeight$ 30Q�5=      
������#���   5?         HeadersVisibility$	 All=�5@      $   HorizontalScrollBarVisibility$ Hidden=�5A         RowBackground
 �����  	DarkBrush   AlternatingRowBackground# [ 5C      $	��274��5E      $	��Top=�6    $	��408��5F      $��
340,50,0,0q�5G      ��5D      �� *	UsersGrid+��5H      �� 5I      $	 0.5,1&�6&   $
 0.5,0&�67   .��5J      � $ 	#FFE5E5E8��6#   $ 0.019Q�65   � 5K      $ 	#FFC2E9FD��6#   $ 1Q�65   5L         Columns 5N      0  *System.Windows.Controls.DataGridTextColumn  5O      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Логин��6@      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6O      
FontWeight$
 Bold"�6[      
Foreground �	#FF236A851  +System.Windows.Controls.DataGridBoundColumn   Binding 6&   �� *login+6m     5P      $ Пароль��6C   $	 100 6S    6&   �� *
password+6S     5Q      $ Имя��6F   $	 100 6S    6&   �� *	firstName+6S     5R      $ Фамилия��6F   $	 100 6W    6&   �� *
secondName+6W   5T      �� 5U   
   -   5         ��Name$ updateButton��5W        
BaseButton#��[ 5V      $��Обновить��5Y      $��363,348,330.6,30q�5Z   ,   ��6   �� *
UpdateUser+6,   �� 5[   
   -   5        $ deleteButton��5^      $	��100��5\      #��[ 5]      $��Удалить��5`      $��513,348,166.6,30q�5a   ,   ��6   �� *
RemoveUser+6,   �� 5b   
   #��[ 5c      $��
Назад��5d      $��671,348,22.6,30q�5f   ,   ��5e      ��  �� RelativeSource ��  �� Mode$ FindAncestor=� �� AncestorType" ���5f      �� *
CloseAdmin+6,   5g      5h      