   M S B A M L   `   `   `  ����  ManchesterGirlGeeks2013*    $ManchesterGirlGeeks2013.Views.GitHub   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -   5          N�Name$  _gitPage��5       N� Title$ GitHub��5	      .��5      � $��0,50,0,0q�6    � RowDefinitions 5   
   �� 5      $	��25* �6   �� 5      $	��65* �6   �� 5      $
��Auto �6   .+�5   
   ��  �� Orientation$ Vertical=�6   $��0��5      
�������$	��100��5      $
��Left=�5      $��20,0,0,0q�5      .+�5      �� $��Number of commits��6   $	��300��5      $��Center=�5      $��Center=�5      
��� � �$��36(�5      �� 5      $	��100��5      $��Center=�5       $��Center=�5!      $��36(�5"       �� TextAlignment$ Center=�6&   ��5      �� *CommitCount+ �� ElementName$ _gitPage�� �� UpdateSourceTrigger$ PropertyChanged=�5"   &   5%      � 5&   
   $��1��6   $
��Left=�6   $��20,0,0,0q�5'       5(      �� 5)      $
��Auto �6    �� 5*      $��33 �6    �� 5+      $��33 �6    �� 5,      $��33 �6    �� 5-      $��33 �6    �� 5.      $��33 �6    �� 5/      $��33 �6    �� 50      $
��Auto �6    .+�53      �� $��Last Commit��6   $��36(�54      
�������$	��300��56      $ Center=�57      �� 58      $
��Date��6   $ Center=�59      $��25(�5:      
�������$��1��5<      $	��300��5=      �� 5>      $��24(�5?      
���   �
�������$ Center=�5B      $��2��5C      $	��300��5D      ��5>      �� *LastCommitdetail.Date+$ _gitPage��$ PropertyChanged=�5D      �� 5E      $��ID��6   $��24(�5F      
���   �$ Center=�5H      $��3��5I      $	��300��5J      �� 5K      $��24(�5L      
���   �
�������$ Center=�5O      $��4��5P      $	��300��5Q      ��5K      �� *LastCommitdetail.ID+$ _gitPage��$ PropertyChanged=�5Q      �� 5R      $
��Name��6   $��24(�5S      
���   �$ Center=�5U      $��5��5V      $	��300��5W      �� 5X      $��24(�5Y      
���   �
�������$ Center=�5\      $��6��5]      $	��300��5^      ��5X      �� *LastCommitdetail.Name+$ _gitPage��$ PropertyChanged=�5^      �� 5_      $��7��5`      ��5_      �� *LastCommitdetail.Avatar+$ _gitPage��$ PropertyChanged=�5`      5a      �� 5c   
   -   5        $<��6/ManchesterGirlGeeks2013;component/Images/Previous.png��5c      $��2��5d      $��Right=�5e      $��50��5f      $��50��5g       � Cursor$
 Hand��5h      5i      5j      5k      