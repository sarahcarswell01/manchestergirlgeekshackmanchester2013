   M S B A M L   `   `   `  ����  ManchesterGirlGeeks2013*    $ManchesterGirlGeeks2013.Views.Trello   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      f bTelerik.Windows.Controls, Version=2013.3.1016.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7?telerik1http://schemas.telerik.com/2008/xaml/presentation  5      -   5          N�Name$  _trelloPage��5
       N� Title$ Trello��5	       � 	Resources 5         	_listItem �� Orientation �� SelectedIndex  	itemStyle �� 
TargetType-  'Telerik.Windows.Controls.RadListBoxItem �� 	Resources �� Color �� Opacity	 �� Property
 �� Value �� Triggers P� Property P� Value2  ,Telerik.Windows.Controls.Primitives.ListItem��%�  &	        &	     �� 5   
   .R�5      �� $ 
Horizontal=�6   $	��400��5      .+�5      �� $	��200��62   ��6   �� *Name+62   �� 5      $	��200��5      $ 0��5      $��20,0,0,0q�5      ��5      �� *	Members+5      5      5      �� 5   
   "  6"    5      ���� 5      $	 Red��6T   $ 0Q�6`   (��       6"   * SystemColors.HighlightBrushKey+)6`   �� 5      $	 Red��6R   $ 0Q�6^   (��       6"   *SystemColors.ControlBrushKey+)6^   5      .�5       �� 	 � ��$
 50��6'   �� 5!      	 � ��
 6+   Z� �� 5"      	 � ��$	
 400��6&   �� 5#      	 � ��$

 Bold"�6+   �� 5$      	 � ��$
 Segoe UI)�6+   �� 5%      	 � ��$
 14(�6)   �� 5&      	 � ��

 �����6,   �� 5'      	 � ��$
 1q�60    5)      P� 5*       �@J�IsMouseOver . . �5+      �� 	 � ��$
 0.2,0.2,0,0.2q�68   �� 5,      	 � ��
 63   Z� �� 5-      	 � ��

 �  ��63   5.      P� 5/       �@ 
IsSelected . . �50      �� 	 � ��$
 0.2,0.2,0,0.2q�68   �� 51      	 � ��
 63   Z� �� 52      	 � ��

 �  ��63   53      55      56      .��58      � $��0,50,0,0q�6    � RowDefinitions 59   
   �� 5:      $	��25* �6   �� 5;      $	��75* �6    � ColumnDefinitions 5=   
   �� 5>      $	��33* �6   �� 5?      $	��33* �6   �� 5@      $	��33* �6   .+�5C   
   �� $ Vertical=�6   $��0��5D      
�������$	��200��5F      $	��150��5G      .+�5H      �� $��To Do��6   $	��100��5I      $��Center=�5J      $��Center=�5K      
���  ��$��36(�5M      �� 5N      $	��100��5O      $��Center=�5P      $��Center=�5Q      $��36(�5R       �� TextAlignment$ Center=�6&   ��5N      �� *	ToDoItems+ �� ElementName$ _trelloPage�� �� UpdateSourceTrigger$ PropertyChanged=�5R   &   5T      �� 5U   
   $ Vertical=�6   $��1��5V      
�������$	��200��5X      $	��150��5Y      .+�5Z      �� $��Doing��6   $	��100��5[      $��Center=�5\      $��Center=�5]      $��36(�5^      
��� ���5_      �� 5`      $	��100��5a      $��Center=�5b      $��Center=�5c      $��36(�5d      $ Center=�5e      ��5`      �� *
DoingItems+$ _trelloPage��$ PropertyChanged=�5e      5g      �� 5h   
   $ Vertical=�6   $��2��5i      
�������$	��200��5k      $	��150��5l      .+�5m      �� $
��Done��6   $	��100��5n      $��Center=�5o      $��Center=�5p      $��36(�5q      
��� � �5r      �� 5s      $	��100��5t      $��36(�5u      $��Center=�5v      $��Center=�5w      $ Center=�5x      ��5s      �� *	DoneItems+$ _trelloPage��$ PropertyChanged=�5x      5z      � 5{   
   $��1��6   $��3��5|       5}      �� 5~      $
��Auto �6    �� 5      $��* �6    �� 5�      $
��Auto �6    .+�5�      �� $��In Progress��6   $��48(�5�      
�������5�      )  #Telerik.Windows.Controls.RadListBox  5�      $��1��6!   $
��Left=�5�   !   #��[  5�   !   $	��600��5�   !   $	��500��5�   !   +  %Telerik.Windows.Controls.StyleManager   Theme-  'Telerik.Windows.Controls.ThemeConverter$ Windows8 5�   !   #��[ 5�   !   ��5�   !   �� *Cards+$ _trelloPage��$ PropertyChanged=���5�   !   Z� �� 5�      -   5        $<��6/ManchesterGirlGeeks2013;component/Images/Previous.png��5�      $��2��5�      $��Right=�5�      $��50��5�      $��50��5�       � Cursor$
 Hand��5�      5�      5�      5�      5�      