   M S B A M L   `   `   `  ����N  JCineExpotronica2019, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:CineExpotronica2019CineExpotronica2019  5      M+clr-namespace:CineExpotronica2019.ViewModelCineExpotronica2019.ViewModel  5          CineExpotronica2019.App   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      3local!clr-namespace:CineExpotronica2019     5      :vm+clr-namespace:CineExpotronica2019.ViewModel     5        �� 	Resources  5       �� MergedDictionaries �� Source   PrimaryHueLightBrush �� Color " PrimaryHueLightForegroundBrush  PrimaryHueMidBrush   PrimaryHueMidForegroundBrush  PrimaryHueDarkBrush ! PrimaryHueDarkForegroundBrush  SecondaryAccentBrush " SecondaryAccentForegroundBrush  ComboBoxNormalBorderBrush !	 ComboBoxNormalBackgroundBrush #
 ComboBoxDisabledForegroundBrush # ComboBoxDisabledBackgroundBrush  ComboBoxDisabledBorderBrush �� 
TargetType   ComboBoxToggleButtonTemplate � ColumnDefinitions �� CornerRadius �� Triggers P� Property	 P� Value
 �� 
TargetName �� Property �� Value �� 
TargetType �� 	ClickMode d� 	IsChecked �� Path �� RelativeSource �� Mode J� IsHitTestVisible �� SelectionBoxItem �� SelectionBoxItemTemplate �� 
IsReadOnly �� 
IsReadOnly � AllowsTransparency �� IsDropDownOpen J� SnapsToDevicePixels � ActualWidth �� MaxDropDownHeight-  'System.Windows.Input.KeyboardNavigation   DirectionalNavigation�� 5	   
    5
      �� 5      $e _pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Light.xaml?�6%   �� 5      $h bpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Defaults.xaml?�6%   �� 5      $t npack://application:,,,/MaterialDesignColors;component/Themes/Recommended/Primary/MaterialDesignColor.Blue.xaml?�6%   �� 5      $u opack://application:,,,/MaterialDesignColors;component/Themes/Recommended/Accent/MaterialDesignColor.Indigo.xaml?�6%   %�  &	        &	 #     &	 D     &	 g     &	 �     &	 �     &	 �     &	 �     &	     &		 /    &	
 M    &	 k    &	 �    &	 �    7  7 	 7 	 7  7  7  7 
 '��     7  7  7 
 �� 5      $ 	#FF999999��6;   �� 5      $ #333333��6E   �� 5      $ 	#FF31577E��69   �� 5      $ #FFFFFF��6C   �� 5      $ 	#FF4D4D4D��6:   �� 5      $ #FFFFFF��6D   �� 5      $ #689f38��6;   �� 5      $ #FFFFFF��6E   �� 5      $ #e3e9ef��6@   �� 5      $
 #fff��6D   �� 5      $
 #888��6F   �� 5      $
 #eee��6F   �� 5      $
 #888��6B   �� 5      " d�6   .R�5       �  5!      �� 5"      �� 5#      $��20 �6+   .+�5%      �� $��Border��61   $��2��6   8��  $ 0��5'      $��
1, 1, 1, 1q�6    8�� 5(      �� 5)      $��ButtonBorder��6T   $��1��6   $��
1, 1, 1, 1q�6-   ���#444$ 
0, 0, 0, 0��5*      $��
0, 0, 0, 0q�6)   8�� 5+      F� 5-      $��Arrow��6   $��1��6(   =����        �    �� � 	= ��[ � z �� � z     � 	=  	= 	$��Center=�5/      ���#444$��Center=�50      51       52      P� 53       �@J�IsMouseOver	 . . �54      �� $
 ButtonBorder��6=    � ��
 �����6W   55      P� 56       �@d�	IsChecked$
	 TrueY�6@   . �57      �� $
 ButtonBorder��6=    � ��
 �����6W   �� 58      $
 Arrow��67    � �� �	#FF8D979E6J   59      P� 5:       � {�	 .  . �5;      �� $
 Border��6=   8   � ��6Q   �� 5<      $
 ButtonBorder��6=   8   � ��6W   �� 5=      $
 ButtonBorder��6?   8   � ��6Y   �� 5>      8   � ��6C   �� 5?      $
 Arrow��67    � �� �#9996J   5@      5B      �� 5C      " ��6   .�5D      ��  �@J�SnapsToDevicePixels . 6B   �� 5E       �@�OverridesDefaultStyle . 6K   �� 5F       � ��$
 Auto=�6O   �� 5G       � ��$
 Auto=�6M   �� 5H       � �� . 6B   �� 5I       � ��
 �   �6;   �� 5J       �@�FocusVisualStyle 6F   Z� �� 5K       � �� 5L      �� 5M      " ��6*   .R�5N      � .+�5O   "   d� $��ToggleButton��6/   $��2��6C   $ Press=�5P      |�.  8��   5Q      �� $ IsDropDownOpen� �� *TemplatedParent+$ TwoWay=�5R      �� 5T   "   $��ContentSite��63   $��5, 3, 23, 3q�6F    .  $
��Left=�5U      $��Center=�6:   #��z 5V      #��z 5W      #��z��5X      �� 5Y   "   $��PART_EditableTextBox��6*   $��3, 3, 23, 3q�6F   # z 5Z      $y�Hidden=�5[      
������ $
��Left=�5\      $��Center=�61   |�. .��5]   (   ��5^   &   �� 5_   *   " ��6:   .R�5`   .   �� $��PART_ContentHost��65   |�.  6M   5a   +   .��5b   8   5c   #   � 5e   "   $��Popup��6(   $��Bottom=�65   |�.   . #��z 5g      $��Slide=�5h      .��5i   &   � $��DropDown��6+    . #��z 5j      #��z 5k      .+�5l   *   �� $��DropDownBorder��61   
�������$��
0, 1, 0, 0q�6Z   $ 0��5m      $��1,1,1,1q�6*   8�� 5n      �� 5o   *   $��4q�67    . .��5p   .   �� $ 	Contained=�6=   5q   +   5r   '   5s   #   5t       5u      P� 5v   "    �@��HasItems	 .  . �5w   &   �� $
 DropDownBorder��6S    � ��$ 95��6o   5x   #   P� 5y   "    � {�	 .  . �5z   &   �� 8   � ��6O   5{   #   P� 5|   "    �@��
IsGrouping	 . . �5}   &   ��  � �� .  6V   5~   #   P� 5   "    �@��
IsEditable	 . . �5�   &   ��  �@ 	IsTabStop .  6U   �� 5�   &   $
 PART_EditableTextBox��6M    � y�$ Visible=�6o   �� 5�   &   $
 ContentSite��6M    � y�$ Hidden=�6f   5�   #   5�      5�      5�      5�      5�      