   M S B A M L   `   `   `  ����H  DVistasCineWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:VistasCineWPFVistasCineWPF  5   	   )    #VistasCineWPF.Views.RegistroUsuario   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:VistasCineWPF     5   	     � Title$  Registro de usuario��5   	   $	��350��6%   $	��600��62   .��5	      �� .+�5
   
   � .+�5      �� $��Cine Universal��6   $��Center=�6-   $	��142��6J   $��Cambria)�6V   $��20(�6k   $��222,0,229.6,-0.4q�6y   5      � 5   
    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   .+�5      �� $��LogoCine.jpg��6   �� 5      $��1��6   $��20,0,0,0q�6)   .+�5      �� $��Nombre��6   $
��left=�6)   ���	#FF5D5A5A6D   �� 5      -   5         ��Name$ txtNombreRegistro��5      $
��left=�65   $��0,0,0,3q�6�   $��23��6�   $	��120��6�   ��6P   �� *WorkingItem.nombre+ �� Mode$ TwoWay=�6�   �� 5      $��Apellido paterno��6   $
��Left=�63   ���	#FF5D5A5A6N   �� 5      -   5        $ txtApellidoPa��5      $
��left=�6g   $��0,3,0,3q�6�   $��23��6�   $	��120��6�   ��61   �� *WorkingItem.apPaterno+$ TwoWay=�6�   �� 5      $��Apellido materno��6   $
��Left=�63   ���	#FF5D5A5A6N   �� 5      -   5        $ txtApellidoMa��5      $
��left=�6h   $��0,3,0,3q�6�   $��23��6�   $	��120��6�   ��61   �� *WorkingItem.apMaterno+$ TwoWay=�6�   �� 5      $��Nombre de usuario��6   $
��Left=�65   ���	#FF5D5A5A6P   �� 5      $
��left=�6   $��0,3,0,3q�6o   $��23��6�   $	��120��6�   ��65   �� *WorkingItem.nombre_usuario+$ TwoWay=�6�   5      �� 5      $��2��6   .+�5       �� $��Contraseña��6   $
��left=�6-   ���	#FF5D5A5A6H   �� 5!      $
��left=�6   $��0,0,0,3q�6f   $��23��6w   $	��120��6�   ��65   �� *WorkingItem.contra+$ TwoWay=�6�   �� 5"      $��Confirmar contraseña��6   $
��Left=�67   ���	#FF5D5A5A6R   �� 5#      $
��left=�6   $��0,3,0,3q�65   $��23��6F   $	��120��6R   �� 5$      $��Telefono��6   $
��Left=�6+   ���	#FF5D5A5A6F   �� 5%      $
��left=�6   $��0,3,0,3q�6n   $��23��6   $	��120��6�   ��66   �� *WorkingItem.telTaquillero+$ TwoWay=�6�   �� 5&      $��Tipo de usuario��6   ���	#FF5D5A5A62   �� 5'      $	��120��6�   $
��Left=�6�   ��6   �� *ItemsComboBox+ �� SelectedItem 6A   �� *WorkingItem.tipoUsuario+$ TwoWay=�6�   5(      �� 5)      $
��Left=�6   $	��100��6/   $��
74,113,0,0q�6<   $	��Top=�6P   $	��100��6h   5*      �� 5+   
   $��Registrarse��6   $	��100��6F   $��
120,20,0,0q�6R   ��6'   �� *
AddCommand+6R   5,      5-      