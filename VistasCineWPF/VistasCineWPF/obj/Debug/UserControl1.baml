   M S B A M L   `   `   `  ����H  DVistasCineWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:VistasCineWPFVistasCineWPF  5           VistasCineWPF.UserControl1   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:VistasCineWPF     5      
�������  � DataContext  5
      ��  �� RelativeSource �� *Self+.��5      �� .+�5   
   �� $��Center=�6   $��SEATING CHART��61   $��24(�6F   $
��0,10q�6T   �� 5   
   ��6   �� *Seats+��5      �� 5      .R�5      � .+�5      ��  ��Name$
 Seat��6$   $��25��62   $��25��6=   
���   �
��� � �$	��1,2q�6e   �� 5       �� TextAlignment$ Center=�65   $��Center=�6L   
�������$
��Bold"�5   /   ��5   $   �� 5   /   5       �� Triggers 5      P� 5       P� Property �@J�IsMouseOver P� Value . . �5      ��  �� 
TargetName$
 Seat��6%    �� Property �@J�Effect	 �� Value	 5   "   3  -System.Windows.Media.Effects.DropShadowEffect  5   &   
   Color$	
 Red��67      ShadowDepth$ 0Q�6C   5      5      5      ��5       �� 5!      .R�5"      � $	��300��6    $	��550��6-   5#      5%      5&      5'      