   M S B A M L   `   `   `  ����[  WSistem za upravljanje sadrzajima, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:Sistem_za_upravljanje_sadrzajima.Windows(Sistem_za_upravljanje_sadrzajima.Windows  5   	   W SNotification.Wpf, Version=8.0.0.0, Culture=neutral, PublicKeyToken=1acac493089262b5_Aclr-namespace:Notification.Wpf.Controls;assembly=Notification.WpfNotification.Wpf.Controls 6N   :    4Sistem_za_upravljanje_sadrzajima.Windows.PreviewData   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Hlocal6clr-namespace:Sistem_za_upravljanje_sadrzajima.Windows     5   	   [notificationsAclr-namespace:Notification.Wpf.Controls;assembly=Notification.Wpf     6N   X TFontAwesome5.Net, Version=2.1.11.0, Culture=neutral, PublicKeyToken=9cfaf01297a008f8/fa5%http://schemas.fontawesome.com/icons/  6�   -   5          � Title$  PreviewData��5   	   $	��400��6   $	��650��6*    � 
ResizeMode$ NoResize=�5	   	    � WindowStyle$
 None=�5   	    � AllowsTransparency . 
������  � 	Resources 5         DefaultButtonStyle �� 
TargetType �� Property �� Value��%Z   &	        �� 5   
   " ��5      .�5      ��  � ��$ 12(�5      5      5      .��5      �� $	��650��5   	   $	��400��5   	   .+�5   
   F� -   5        $��UIPath��5      
�������$��2��5       ��5!      �� 5"       �� ImageSource$ /Image/Background.jpg��6   	 j� Stretch$	 UniformToFill=�5#      
 j� 
AlignmentX$
 Center=�65    j� 
AlignmentY$ Center=�6I   ��5%      B� 5&      .��5'      E�  E� 
StartPoint$ 50, 0&�6!   .��5(      ��  �� Point$ 0, 50&�6&   �� 5)      $ 0, 350&�6&   �� 5*      $ 50,400&�6&   �� 5+      $ 600, 400&�6&   �� 5,      $ 650, 350&�6&   �� 5-      $ 650, 50&�6&   �� 5.      $ 600, 00&�6&   5/      50      52      �� 54   
   -   5         ��Name$ AddImage_img��54       �� Left$ 40��55      
 �� Top$ 40��56      $	��140��57      $	��140��58      $��/Image/preview.jpg��59      �� 5;   
   $	 360��6   $	 120��5<      $	��ID:��5=      $
��Bold"�5>      $��15(�5?      �� 5A   
   -   5         ��Name$ Id_tb��5A      $	 430��5B      $	 120��5C      $	��180��5D      $��30��5E      
�������$�� ��5G      �� 5I   
   $	 360��6   $ 40��5J      $��Name:��5K      $
��Bold"�5L      $��15(�5M      �� 5O   
   -   5        $ Name_tb��5O      $	 430��5P      $ 40��5Q      $	��180��5R      $��30��5S      
�������$�� ��5U      �� 5W   
   -   5         ��Name$ 
AddRtf_rtf��5W      $ 40��5X       �� Bottom$ 70��5Y      $	��570��5Z      $	��140��5[      
������� �� 
IsReadOnly . 5^      �� 5`   
    �� Right$ 42��6   $ 72��5a      $��20��5b      $��20��5c      
������ .@�5e      �� -   5        $ NumberOfWords_rtf��5e      $��Center=�63   $��Center=�6P   5f      �� 5h   
   -   5         ��Name$ ExitPreview_btn��5h      $ 20��5i      $	 290��5j      $��80��5k      $��30��5l      $
��Exit��5m      $
��Bold"�5n      $��17(�5o      
������� � ToolTip$ Go back��5r       � Cursor$
 Hand��5s      ��5t      �� 5u       �� BasedOn# [  5v      " ��5w       �� Triggers 5x      P� 5y       P� Property �@J�IsMouseOver P� Value . 5}      :� 5       :� RoutedEvent$ 
MouseEnter��6'   [�5�      �� 5�   "   .��5�   &   �� .��5�   *   W�  �� TargetProperty$ FontSize�5�   -   	 W� To$ 14X�5�   -     g� Duration$  	0:0:0.200D�5�   -   5�   '   5�   #   5�      :� 5�      $ 
MouseLeave��6'   [�5�      �� 5�   "   .��5�   &   �� .��5�   *   W� $ FontSize�5�   -   $ 12X�5�   -   $  	0:0:0.400D�5�   -   5�   '   5�   #   5�      5�      5�      5�      5�      