   M S B A M L   `   `   `  ����[  WSistem za upravljanje sadrzajima, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:Sistem_za_upravljanje_sadrzajima.Windows(Sistem_za_upravljanje_sadrzajima.Windows  5   	   W SNotification.Wpf, Version=8.0.0.0, Culture=neutral, PublicKeyToken=1acac493089262b5_Aclr-namespace:Notification.Wpf.Controls;assembly=Notification.WpfNotification.Wpf.Controls 6N   >    8Sistem_za_upravljanje_sadrzajima.Windows.AddFootballClub   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   X TFontAwesome5.Net, Version=2.1.11.0, Culture=neutral, PublicKeyToken=9cfaf01297a008f8/fa5%http://schemas.fontawesome.com/icons/  5   	   Blocal6clr-namespace:Sistem_za_upravljanje_sadrzajima.Windows  5   	   UnotificationsAclr-namespace:Notification.Wpf.Controls;assembly=Notification.Wpf  6N   -   5          � Title$  AddFootballClub��5	   	   $	��400��6!   $	��650��6.    � 
ResizeMode$ NoResize=�5
   	    � WindowStyle$
 None=�5   	    � 	Resources 5         DefaultButtonStyle �� 
TargetType �� Property �� Value��%Z   &	        �� 5   
   " ��5      .�5      ��  � ��$ 12(�5      5      5      .��5      �� $	��650��5   	   $	��400��5   	    5   
   3  -System.Windows.Media.Effects.DropShadowEffect  MouseOverDropShadowEffect   	Direction   Opacity	   ShadowDepth
   Color��%h   &	         5      $	 320Q�5      $ 80Q�5      $	 10Q�5       $
 	PeachPuff��5!      5"      .+�5$   
   F� -   5        $��UIPath��5%      
�������$��2��5'      ��5(      �� 5)       �� ImageSource$ /Image/Background.jpg��6    j� Stretch$ UniformToFill=�5*       j� 
AlignmentX$ Center=�65    j� 
AlignmentY$ Center=�6I   ��5,      B� 5-      .��5.      E�  E� 
StartPoint$
 0, 0&�6!   .��5/      ��  �� Point$ 0,400&�6&   �� 50      $ 650,400&�6&   �� 51      $ 650,0&�6&   �� 52      $
 0, 0&�6&   53      54      56      0  *Notification.Wpf.Controls.NotificationArea  58   
   -   5          Name$' !WindowNotificationAreaAddingError��59       K� ZIndex$
 1000��5:         MaxItems$ 3��5;         Position$ BottomRight=�5<       �� Right$	 100��5=       �� Bottom$ 00��5>      $	��100��5?      $	��500��5@      �� 5B   
   -   5         ��Name$ AddImage_img��5B       �� Left$ 20��5C      
 �� Top$ 20��5D      $	��100��5E      $	��100��5F      $��/Image/preview.jpg��5G      �� 5I   
   -   5         ��Name$ ChoosePicture_btn��5I      $ 20��5J      $	 140��5K      $��Choose picture��5L      $
��Bold"�5M      $��5q�5N      
������� � ToolTip$' !Choose some picture from computer��5P       � Cursor$
 Hand��5R      ��5S      �� 5T       �� BasedOn# [  5U      " ��5V       �� Triggers 5W      P� 5X       P� Property �@J�IsMouseOver  P� Value  . 5\      :� 5^      ! :� RoutedEvent$! 
MouseEnter��6'   [�5_      �� 5`   "   .��5a   &   �� .��5b   *   W� " �� TargetProperty$" FontSize�5c   -   	# W� To$# 14X�5d   -   $ g� Duration$$ 	0:0:0.200D�5e   -   5f   '   5g   #   5i      :� 5j      $! 
MouseLeave��6'   [�5k      �� 5l   "   .��5m   &   �� .��5n   *   W� $" FontSize�5o   -   $# 12X�5p   -   $$ 	0:0:0.400D�5q   -   5r   '   5s   #   5u      5w      5y      �� 5{   
   $	 160��6   $ 40��5|      $	��ID:��5}      $
��Bold"�5~      $��15(�5      �� 5�   
   -   5        % ��Name$% Id_tb��5�      $	 200��5�      $ 40��5�      $	��140��5�      $��30��5�      5�      �� 5�   
   -   5        & ��Name$& Id_error��5�      $	 180��5�      $ 90��5�      $��30��5�      $	��180��5�      
���  ��$��11(�5�      $�� ��5�      �� 5�   
   $	 360��6   $ 40��5�      $��Name:��5�      $
��Bold"�5�      $��15(�5�      �� 5�   
   -   5        $% Name_tb��5�      $	 430��5�      $ 40��5�      $	��140��5�      $��30��5�      5�      �� 5�   
   -	   5        $& 
Name_error��5�      $	 410��5�      $ 90��5�      $��30��5�      $	��180��5�      
���  ��$��11(�5�      $�� ��5�      �� 5�   
   -
   5        ' ��Name$' 
AddRtf_rtf��5�      $ 20��5�      $ 70��5�      $	��610��5�      $	��140��5�      
�������5�      �� 5�   
   $ 22��6   $ 72��5�      $��20��5�      $��20��5�      
������ .@�5�      �� -   5        ( ��Name$( NumberOfWords_rtf��5�      $��Center=�63   $��Center=�6P   5�      c� 5�   
   -   5        ) c�Name$) ToolBar_rtf��5�      $	 170��5�      $	 140��5�      $��30��5�      $	��420��5�      
�������.@�5�      d� -   5        * d�Name$* Bold_btn��5�      $ ��EditingCommands.ToggleBold��5�      $
 Bold��5�      .��5�        FontAwesome5.SvgAwesome  $��15��6!   $��Center=�5�   !   $��Center=�5�   !   +   
Foreground
+ �   �,   Icon$, 
Solid_Bold=�5�   !   5�      �� 5�      d� 5�      -   5        $* 
Italic_btn��5�      $"��EditingCommands.ToggleItalic��5�      $ Italic��5�      .��5�        $��15��6!   $��Center=�5�   !   $��Center=�5�   !   
+ �   �$, Solid_Italic=�5�   !   5�      �� 5�      d� 5�      -   5        $* Underline_btn��5�      $%��EditingCommands.ToggleUnderline��5�      $ 	Underline��5�      .��5�        $��15��6!   $��Center=�5�   !   $��Center=�5�   !   
+ �   �$, Solid_Underline=�5�   !   5�      �� 5�      �� 5�      -   5        - ��Name$- FontFamily_cb��5�      $	��120��5�       . �� IsTextSearchCaseSensitive. .  / �� IsTextSearchEnabled/ . $ Select font family��5�      �� 5�      �� 5�      -   5        $- FontSize_cb��5�      $��70��5�      . .  / . $ Select font size��5�      �� 5�      �� 5�      -   5        $- FontColor_cb��5�      $	��120��5�      . .  / . $ Select font color��5�      �� 5�      5�      �� 5�   
   -   5        $ 
AddNew_btn��5�      $	��Add��5�      $ 20��5�      $ 20��5�      $��80��5�      $��25��5�      
�������$$ Finish adding of football club��5�      $
��Bold"�5�      $
 Hand��5�      ��5      �� 5     # [  5     " ��5      5     P� 5      �@J�IsMouseOver  . 5	     :� 5     $! 
MouseEnter��6'   [�5     �� 5  "   .��5  &   �� .��5  *   W� $" FontSize�5  -   $# 14X�5  -   $$ 	0:0:0.200D�5  -   5  '   5  #   5     :� 5     $! 
MouseLeave��6'   [�5     �� 5  "   .��5  &   �� .��5  *   W� $" FontSize�5  -   $# 12X�5  -   $$ 	0:0:0.400D�5  -   5  '   5   #   5"     5$     5&     �� 5(  
   -   5        $ ExitAdding_btn��5(     $
��Exit��5)     $ 20��5*     $ 20��5+     $��80��5,     $��25��5-     
�������$
 Exit��5/     $
��Bold"�50     $
 Hand��52     ��53     �� 54     # [  55     " ��56      57     P� 58      �@J�IsMouseOver  . 5<     :� 5>     $! 
MouseEnter��6'   [�5?     �� 5@  "   .��5A  &   �� .��5B  *   W� $" FontSize�5C  -   $# 14X�5D  -   $$ 	0:0:0.200D�5E  -   5F  '   5G  #   5I     :� 5J     $! 
MouseLeave��6'   [�5K     �� 5L  "   .��5M  &   �� .��5N  *   W� $" FontSize�5O  -   $# 12X�5P  -   $$ 	0:0:0.400D�5Q  -   5R  '   5S  #   5U     5W     5Y     5Z     5[     