   M S B A M L   `   `   `  ����  ManchesterGirlGeeks2013+    %ManchesterGirlGeeks2013.Views.Twitter   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      f bTelerik.Windows.Controls, Version=2013.3.1016.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7?telerik1http://schemas.telerik.com/2008/xaml/presentation  5      -   5          N�Name$  _twitterPage��5
       N� Title$ Twitter��5	       � 	Resources 5         	_listItem �� Orientation  	itemStyle �� 
TargetType-  'Telerik.Windows.Controls.RadListBoxItem �� 	Resources �� Color �� Opacity �� Property	 �� Value
 �� Triggers P� Property P� Value2  ,Telerik.Windows.Controls.Primitives.ListItem��%�  &	        &	 H    �� 5   
   .R�5      �� $ Vertical=�6   .+�5      �� $ 
Horizontal=�6   .+�5      �� 
����ح���6    �� *user.screen_name+6C   �� 5      $��20,0,0,0q�6<   $��Right=�6N   ��6    �� *
created_at+6N   5      �� 5      $
��0,10q�63   ��6   �� *text+63   5      5      �� 5   
   "  6"    5      ���� 5      $	 Red��6T   $ 0Q�6`   (��       6"   * SystemColors.HighlightBrushKey+)6`   �� 5      $	 Red��6R   $ 0Q�6^   (��       6"   *SystemColors.ControlBrushKey+)6^   5      .�5      ��  � ��$	 50��6'   �� 5       � ��	 6+   Z� �� 5        � ��$
	 Bold"�6+   �� 5!       � ��$	 Segoe UI)�6+   �� 5"       � ��$	 14(�6)   �� 5#       � ��
	 �����6,   �� 5$       � ��$	 1q�60   
 5&      P� 5'       �@J�IsMouseOver . . �5(      ��  � ��$	 0.2,0.2,0,0.2q�68   �� 5)       � ��	 63   Z� �� 5*       � ��
	 �  ��63   5+      P� 5,       �@ 
IsSelected . . �5-      ��  � ��$	 0.2,0.2,0,0.2q�68   �� 5.       � ��	 63   Z� �� 5/       � ��
	 �  ��63   50      52      53      .��54      �  � RowDefinitions 55   
   �� 56      $	��65* �6   �� 57      $
��Auto �6   .+�5:   
   )  #Telerik.Windows.Controls.RadListBox  $
��Left=�6   #��[  5;      $	��500��5<      +  %Telerik.Windows.Controls.StyleManager   Theme-  'Telerik.Windows.Controls.ThemeConverter$ Windows8 5>      #��[ 5?      ��5=      �� *TwitterFeed+ �� ElementName$ _twitterPage�� �� UpdateSourceTrigger$ PropertyChanged=���5@      Z� �� 5A   
   -   5        $<��6/ManchesterGirlGeeks2013;component/Images/Previous.png��5A      $��2��5B      $��Right=�5C      $��50��5D      $��50��5E       � Cursor$
 Hand��5F      5G      5I      5J      