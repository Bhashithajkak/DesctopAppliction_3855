   M S B A M L   `   `   `  ����O  KDesktopApplication 1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:DesktopApplication_1DesktopApplication_1  5   	   '    !DesktopApplication_1.ModifyWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:DesktopApplication_1     5   	   -   5          � Title$  ModifyWindow��5   
   $	��600��6   $	��900��6,    � WindowStyle$
 None=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	   
������  � AllowsTransparency$
 True��5   	    � DataContext 5      )   #DesktopApplication_1.ModifyWindowVM  5   
   .��5      ��  �� CornerRadius$ 20��6   $��4q�5      ��5   
   �� 5       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 1,1&�63   .��5      � 	 � Color$	 #462AD8��6   
 � Offset$
 0Q�6/   � 5      $	 #8A16C1��6   $
 1Q�6/   5      ��5   
   �� 5      $	 0,1&�6"   $	 1,0&�63   .��5      � $	 	#FF04052D��6   $
 0Q�61   � 5      $	 	#FF060A31��6   $

 0.25Q�61   � 5      $	 #181448��6   $

 0.50Q�6/   � 5       $	 	#FF04052D��6   $
 1Q�61   5!      ._�5#   
   � $��10q�6    � RowDefinitions 5%      �� 5&      $	��125 �6    �� 5'      $��* �6    �� 5(      $��80 �6    .+�5+      �� $��0��6   $��10,20,10,20q�6&   .+�5,      �� $��10 20 10 10q�63    �� Padding$ 5q�6H   $��Center=�6U   $��25(�6r   $
��Bold"�6�   
�������$��Book Antiqua)�6�   ��6   �� *Title+6�   5.      �� 5/      $��1��6   $
��10 5q�6&   .+�52      �  � ColumnDefinitions 53      �� 54      $��* �6+   �� 55      $��*  �6+   .+�58      �� $��0��6!   $��40 10q�61   .+�59      �� $��First Name:��6$   $��2q�67   $ 2q�6B   
�������6N   �� 5:      $	��300��6=   $
��Left=�6I   $��2q�6d   $��2q�6o   ��6"   �� *	FirstName+6o   �� 5;      $��
Last Name:��6$   $��2q�66   $ 2q�6A   
�������6M   �� 5<      $	��300��6<   $
��Left=�6H   $��2q�6c   $��2q�6n   ��6"   �� *
LastName+6n   �� 5=      $"��Date Of Birth (YYYY/MM/DD) :��6$   $��2q�6H   $ 2q�6S   
�������6_   �� 5>      $	��300��6?   $
��Left=�6K   $��2q�6f   $��2q�6q   ��6"   �� *DateOfBirth+6q   �� 5@      $
��Age:��6$   $��2q�60   $ 2q�6;   
�������6G   �� 5A      $	��300��67   $
��Left=�6C   $��2q�6^   $��2q�6i   ��6"   �� *Age+6i   �� 5B      $��
GPA Value:��6$   $��2q�66   $ 2q�6A   
�������6M   �� 5C      $	��300��67   $
��Left=�6C   $��2q�6^   $��2q�6i   ��6"   �� *Gpa+6i   5D      �� 5E      $��1��6!   $��10q�61   .+�5G      �� $	��150��6    $	��150��6,   $��20q�6R   ��69   �� *Image+6R   �� 5H      $��Select Image��6!   $��90��68   $��2q�6C   
����� ���6i   �� *AddImageCommand+5I      5M      5P      �� 5Q      $��2��6   $
��10 5q�6&    �� Orientation$ 
Horizontal=�64   $��Center=�6M   .+�5R      �� $
��Save��6   $��10q�6H   $��Bottom=�6U      mainmenubutten#��[  6q   ��6(   �� *SaveCommand+6q   �� 5S      $��Cancel��6   $��10q�6W   $��Bottom=�6d   #��[  6�   ��6*   �� *CloseModifyWindowCommand+6�   5T      5W      5X      5Y      