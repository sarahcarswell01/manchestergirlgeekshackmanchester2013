   M S B A M L   `   `   `  ����R  NManchesterGirlGeeks2013, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:ManchesterGirlGeeks2013.HelperClasses%ManchesterGirlGeeks2013.HelperClasses  5      )    #ManchesterGirlGeeks2013.Views.Timer   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Bhc3clr-namespace:ManchesterGirlGeeks2013.HelperClasses     5      f bTelerik.Windows.Controls, Version=2013.3.1016.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7?telerik1http://schemas.telerik.com/2008/xaml/presentation  5      -   5          N�Name$  _timer��5      $	��400��5
      $	��600��5      .��5      �  � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��1��6   $��0��6!   $��Center=�61   $
��10,5q�6L   $��Count Down Timer:��6Z   �� 5   
   $��1��6   $��1��6   
�������$��2q�6A    �� CornerRadius$ 8��6U   $��Center=�6f   
�������$��5q�6�   ._�5      :   4ManchesterGirlGeeks2013.HelperClasses.TimerTextBlock  -   5          Name$ ttbCountDown��5       :   4ManchesterGirlGeeks2013.HelperClasses.TimerTextBlock   OnCountDownComplete$&  ttbCountDown_OnCountDownComplete��6     IsCountDown .    	IsStarted . $	��180��6�   $��Center=�6�    �� TextAlignment$ Center=�6�   $��24(�6�   	 �� Padding$	 10q�6  
   TimeSpan
 6I   �� *	CountDown+ �� ElementName$ _timer�� �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�6  5      �� 5    
   $��2��6   $��1��6"   $��Center=�62    �� Orientation$ 
Horizontal=�6O   $��5q�6h   .+�5!      �� -   5        $��btnSet��5!      $	��Set��6#   $��40��61   $��3q�6<   6G   �� 5"      -   5        $��btnStart��5"      $��Start��6%   $��40��65   $��3q�6@   6K   �� 5#      -   5        $��btnStop��5#      $
��Stop��6$   $��40��63   $��3q�6>   {�6_   ��  �� Source$ ttbCountDown�� �� Path$ 	IsStarted��� 5$      -   5        $��btnReset��5$      $��Reset��6%   $��40��65   $��3q�6@   6K   5%      �� 5'   
   $��3��6   $��0��6!   $��Center=�61   $
��10,5q�6L   $��Timer:��6Z   �� 5(   
   $��3��6   $��1��6   
�������$��2q�6A   $ 8��6U   $��Center=�6f   
�������$��5q�6�   ._�5)        -   5        $ ttbTimer��5)        . $	��180��6C   $��Center=�6O   $ Center=�6l   $��24(�6�   $	 10q�6�   5*      �� 5,   
   $��4��6   $��1��6"   $��Center=�62   $ 
Horizontal=�6O   $��5q�6h   .+�5-      �� -   5        $��btnSetTimer��5-      $	��Set��6(   $��40��66   $��3q�6A   6L   �� 5.      -	   5        $��btnStartTimer��5.      $��Start��6*   $��40��6:   $��3q�6E   6P   �� 5/      -
   5        $��btnStopTimer��5/      $
��Stop��6)   $��40��68   $��3q�6C   {�6N   �� $ ttbCountDown��$ 	IsStarted�6�   �� 50      -   5        $��btnResetTimer��50      $��Reset��6*   $��40��6:   $��3q�6E   6P   51      �� 54   
   -   5        $<��6/ManchesterGirlGeeks2013;component/Images/Previous.png��54      $��50��55      $��50��56      $
��Fill=�57      $��5��58      $��Right=�59      $��1��5:       � Cursor$
 Hand��5<      5=      5?      