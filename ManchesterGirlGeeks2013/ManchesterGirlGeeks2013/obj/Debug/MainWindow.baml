   M S B A M L   `   `   `  ����  ManchesterGirlGeeks2013(    "ManchesterGirlGeeks2013.MainWindow   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      f bTelerik.Windows.Controls, Version=2013.3.1016.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7?telerik1http://schemas.telerik.com/2008/xaml/presentation  5      -   5          N�Name$  _dash��5       N� Title$ 	HackBoard��5      +  %Telerik.Windows.Controls.StyleManager   Theme-  'Telerik.Windows.Controls.ThemeConverter$ Windows8 5       N� ShowsNavigationUI .   N� WindowHeight$	 600Q�5
       N� WindowWidth$	 750Q�5      ��5	      Z� .��5      � -   5         �Name$ _grid��5      .+�5   
   *  $Telerik.Windows.Controls.RadTileList  -   5          Name$ 
_dashboard��5      $��35,0,0,0q�5      $
��Auto=�5      $
��Auto=�5      
�������.@�5      #  Telerik.Windows.Controls.Tile  -   5          Name$ _twitterView��5      	   TileType$	 Double=�5      
   
IsSelected
 .  
�������.��5      � .+�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      (� D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    6"   .��5      � .+�5   "   � -   5        $��backgroundGrid��5   '   $��48��6=   $��48��6H   $y�	Collapsed=�6T   F� 5   "   ����ЀP���%�Ӡ�򕈡 � O��@�!��w����ӐK9���`�X��K��\�h���Ӡ�;����� ��(0������h���� �����������pl�(�����{Ε0m��tt��R7�@��и5�Ӱ`��P�����(��� �(�0��Ӱ�L�����0rP� J���i�0���� �� ��w��������p��E������������(^���ߵ��2L��}��x���q�ȓ����q/� ��������v��9N���K��@5���A���.��J9�0�4�(�Z���t;�Ȥ~��eU�h��P–�@���P<r�0�����a�����P�T������ �G�`A��@�H�h����dL��j��Ӡ$X�� ��p�y�p�� A��8�!��P.��Q#�����h�'�0#~�z1�� �q�0g:� �q��M;�@hy�h�F��`>��p~e�PE���fv�0��H�v��8����������0������0����PL����4�`����#��=���h��Ӑ�:�����p�f�h��Ь4�� G��А�� /�0�ѕ�����4�PW�Ӏ� ��nV���G��G���`��+�Ӱ�@�-�p#���+��P���%�	 �� Stretch$ Uniform=�6t  ���	#FFAAAAAA$��26��6�  $��26��6�  $��0,0,0,0q�6�   J� RenderTransformOrigin$ 0.5,0.5&�6�  z�5   &   V� 5   *   ~�5    2   ��  �� Angle$ 0Q�6B   �� 5!   2    �� ScaleX$ 1Q�6A    �� ScaleY$ 1Q�6L   5#   +   5%   #   5&      5'      �� 5(      $��Twitter��6$   $��Right=�5)   $   $��Bottom=�5*   $   $��38(�5+   $   
�������5,   $   5-      5.      5/        50      -   5        $ _dilbertView��50      $	 Double=�51      
 .  
�������.��55      �� $��Images/Dilbert.jpg��6   $
��Fill=�64   56        57      -   5        $ _timer��57      $	 Single=�58      
 .  
�������.��5<      � .+�5=      �� $��32(�5>       $��Center=�5?       $��Center=�5@       ��5=       �� *	CountDown+ �� ElementName$ _dash�� �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�5@       5A      5B        5C      -   5        $ _trelloView��5C      $	 Single=�5D      
 .  
�������.��5H      �� $��Images/Trello_logo.png��6   5I        5J      -	   5        $
 _hac��5J      $	 Double=�5K      
 .  
�������.��5O      �� $��Images/Hac.jpg��6   $
��Fill=�60   5P        5Q      -
   5        $
 _git��5Q      $	 Double=�5R      
 .  
�������.��5V      �� $��Images/github.png��6   $
��Fill=�63   5X      5Y      5Z      5[      