   M S B A M L   `   `   `  ����[  WSistem za upravljanje sadrzajima, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:Sistem_za_upravljanje_sadrzajima.Windows(Sistem_za_upravljanje_sadrzajima.Windows  5   	   W SNotification.Wpf, Version=8.0.0.0, Culture=neutral, PublicKeyToken=1acac493089262b5_Aclr-namespace:Notification.Wpf.Controls;assembly=Notification.WpfNotification.Wpf.Controls 6N   <    6Sistem_za_upravljanje_sadrzajima.Windows.DataGridTable   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Hlocal6clr-namespace:Sistem_za_upravljanje_sadrzajima.Windows     5   	   [notificationsAclr-namespace:Notification.Wpf.Controls;assembly=Notification.Wpf     6N   -   5          � Title$  DataGridTable��5   	   $	��400��6   $	��650��6,    � 
ResizeMode$ NoResize=�5	   	    � WindowStyle$
 None=�5   	    � 	Resources 5         DefaultButtonStyle �� 
TargetType �� Property �� Value��%Z   &	        �� 5   
   " ��5      .�5      ��  � ��$ 12(�5      5      5      .��5      �� $	��650��5   	   $	��400��5   	   .+�5   
   F� -   5        $��UIPath��5      
�������$��2��5      ��5      �� 5        �� ImageSource$ /Image/Background.jpg��6    j� Stretch$ UniformToFill=�5!      	 j� 
AlignmentX$	 Center=�65   
 j� 
AlignmentY$
 Center=�6I   ��5#      B� 5$      .��5%      E�  E� 
StartPoint$
 0, 0&�6!   .��5&      ��  �� Point$ 0,400&�6&   �� 5'      $ 650,400&�6&   �� 5(      $ 650,0&�6&   �� 5)      $
 0, 0&�6&   5*      5+      5-      0  *Notification.Wpf.Controls.NotificationArea  5/   
   -   5          Name$" WindowNotificationAreaAdding��50       K� ZIndex$	 100��51         MaxItems$ 3��52         Position$ TopRight=�53       �� Right$ 0��54       �� Bottom$ 0��55      $	��100��56      $	��300��57      &   System.Windows.Controls.DataGrid  59   
   -   5          Name$ Table��59         
IsReadOnly . $	��300��5<      $	��500��5=       �� Left$ 75��5>      
 �� Top$ 20��5?      
������    AutoGenerateColumns .  $
��Auto=�5B      $
��Auto=�5C      ��. ��5:      �� *Clubs+   Columns 5E      4  .System.Windows.Controls.DataGridTemplateColumn  5F      ,  &System.Windows.Controls.DataGridColumn   Header$ Check��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ 80 5G   )      CellTemplate 5H      �� 5I      .R�5J      �� $��Center=�5K   '   $��Center=�5L   '    d� 	IsChecked 5J   '   �� *
Selected+ �� UpdateSourceTrigger$ PropertyChanged=�5L   '   5M      5O        5Q      $
 Name��6)   $	 112 67    5R      �� 5S      .R�5T      �� $��Center=�6(   $��Center=�5U   (   �� 5V   "   -   5        .�5V   D   .�5W   "   �� $��Center=�5X   ,   $��Center=�5Y   ,   ��5W   ,   �� *Name+5Y   ,   5Z   #   5[      5\      5^        5`      $ Picture��6)   $	 140 6:    5a      �� 5b      .R�5c      �� $	��140��5d   $   $	��100��5e   $   ��5c   $   �� *	Picture+5e   $   5f      5h      0  *System.Windows.Controls.DataGridTextColumn  5j      $
 Date��6%   $	 140 5l   %   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5k   %   �� *Date+5l   %   5n      �� 5p   
   $ 20��6   $ 75��5q      $��166.6��5r      .+�5s      �� -   5         ��Name$ Add_btn��5s      $��Add new��5t      $ 75��5u      $ 20��5v      $��10q�5w      
�������$
��Bold"�5y      $��0 0 30 0q�5z        � ToolTip$  Add new footbal club��5|      ! � Cursor$
! Hand��5}      ��5~      �� 5      " �� BasedOn#" [  5�      " ��5�      # �� Triggers# 5�      P� 5�      $ P� Property$ �@J�IsMouseOver% P� Value% . 5�      :� 5�      & :� RoutedEvent$& 
MouseEnter��6+   [�5�   "   �� 5�   &   .��5�   *   �� .��5�   .   W� ' �� TargetProperty$' FontSize�5�   1   	( W� To$( 14X�5�   1   ) g� Duration$) 	0:0:0.200D�5�   1   5�   +   5�   '   5�      :� 5�      $& 
MouseLeave��6+   [�5�   "   �� 5�   &   .��5�   *   �� .��5�   .   W� $' FontSize�5�   1   $( 12X�5�   1   $) 	0:0:0.400D�5�   1   5�   +   5�   '   5�      5�      5�      5�      �� 5�   
   $ 20��6   $ 241.6��5�      $��166.6��5�      .+�5�      �� -   5        $ 
Delete_btn��5�      $��Delete selected��5�      $	 270��5�      $ 20��5�      $��10q�5�      
�������$
��Bold"�5�      $��	15 0 15 0q�5�      $"  Delete selected footbal club��5�      $
! Hand��5�      ��5�      �� 5�      #" [  5�      " ��5�      # 5�      P� 5�      $ �@J�IsMouseOver% . 5�      :� 5�      $& 
MouseEnter��6+   [�5�   "   �� 5�   &   .��5�   *   �� .��5�   .   W� $' FontSize�5�   1   $( 14X�5�   1   $) 	0:0:0.200D�5�   1   5�   +   5�   '   5�      :� 5�      $& 
MouseLeave��6+   [�5�   "   �� 5�   &   .��5�   *   �� .��5�   .   W� $' FontSize�5�   1   $( 12X�5�   1   $) 	0:0:0.400D�5�   1   5�   +   5�   '   5�      5�      5�      5�      �� 5�   
   $ 20��6   $ 75��5�      $��166.6��5�      .+�5�      �� -   5        $ ExitDGT_btn��5�      $
��Exit��5�      $ 75��5�      $ 20��5�      $��10q�5�      
�������$
��Bold"�5�      $��30 0 0 0q�5�      $  Exit to log in window��5�      $
! Hand��5�      ��5�      �� 5�      #" [  5�      " ��5�      # 5�      P� 5�      $ �@J�IsMouseOver% . 5�      :� 5�      $& 
MouseEnter��6+   [�5�   "   �� 5�   &   .��5�   *   �� .��5�   .   W� $' FontSize�5�   1   $( 14X�5�   1   $) 	0:0:0.200D�5   1   5  +   5  '   5     :� 5     $& 
MouseLeave��6+   [�5  "   �� 5  &   .��5  *   �� .��5	  .   W� $' FontSize�5
  1   $( 12X�5  1   $) 	0:0:0.400D�5  1   5  +   5  '   5     5     5     5     5     5     