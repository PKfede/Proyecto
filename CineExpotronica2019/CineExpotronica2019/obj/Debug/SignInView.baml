   M S B A M L   `   `   `  ����N  JCineExpotronica2019, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:CineExpotronica2019CineExpotronica2019  5   	   $    CineExpotronica2019.SignInView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:CineExpotronica2019     5   	     � Title$  Registro��5   	   $	��400��6   $	��800��6'    � WindowStartupLocation$ CenterScreen=�63    � 
ResizeMode$ CanMinimize=�6X    � 	Resources 5	       �� 
TargetType �� Triggers P� Property P� Value �� Property	 �� Value
 �� Self �� RelativeSource �� Path��%�   '��       �� 5
   
   " ��6    5      P� 5       �@=�HasError . . �5      ��  �@�ToolTip	 5      �� # Z
 $2 ,(Validation.Errors).CurrentItem.ErrorContent�5      5      5      .��5      �� $��0,0,9.4,10.4q�6   .+�5   
   � .+�5      �� $��Cine Universal��6   $��Center=�6-   $	��142��6J   $��Cambria)�6V   $��20(�6k   $��222,0,229.6,-0.4q�6y   5      � 5   
    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   .+�5      �� $��LogoCine.jpg��6   �� 5       $��1��6   $��20,0,0,0q�6)   .+�5!      �� $��Nombre��6   $
��left=�6)   ���	#FF5D5A5A6D   �� 5"      -   5         ��Name$ txtNombreRegistro��5"      $
��left=�65   $��0,0,0,3q�6�   $��23��6�   $	��120��6�   ��6P   �� *Nombre+ �� Mode$ OneWayToSource=� �� ValidatesOnDataErrors .  �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5#      $��Apellido paterno��6   $
��Left=�63   ���	#FF5D5A5A6N   �� 5$      -   5        $ txtApellidoPa��5$      $
��left=�6�   $��0,3,0,3q�6�   $��23��6�   $	��120��6�   ��61   �� *	ApPaterno+$ OneWayToSource=� . $ PropertyChanged=�6�   �� 5%      $��Apellido materno��6   $
��Left=�63   ���	#FF5D5A5A6N   �� 5&      -   5        $ txtApellidoMa��5&      $
��left=�6�   $��0,3,0,3q�6�   $��23��6�   $	��120��6�   ��61   �� *	ApMaterno+$ OneWayToSource=� . $ PropertyChanged=�6�   �� 5'      $��Nombre de usuario��6   $
��Left=�65   ���	#FF5D5A5A6P   �� 5(      -   5        $��txtNombreUsuario��5(      $
��left=�62   $��0,3,0,3q�5)   �   $��23��6�   $	��120��6�   ��5(   M   �� *Nombre_usuario+$ OneWayToSource=� . $ PropertyChanged=�5)   �   5*      �� 5+      $��2��6   .+�5,      �� $��Contraseña��6   $
��left=�6-   ���	#FF5D5A5A6H   �� 5-      $
��left=�6   $��0,0,0,3q�6�   $��23��6�   $	��120��6�   ��65   �� *Contra+$ OneWayToSource=� . $ PropertyChanged=�6�   �� 5.      $��	Teléfono��6   $
��Left=�6+   ���	#FF5D5A5A6F   �� 5/      $
��left=�6   $��0,3,0,3q�6�   $��23��6�   $	��120��6�   ��66   �� *TelTaquillero+$ OneWayToSource=� . $ PropertyChanged=�6�   �� 50      $��Tipo de usuario��6   ���	#FF5D5A5A62   �� 51       �� SelectedIndex$ 0��6�   $	��120��6�   $
��Left=�6�   ��6   �� *ItemsComboBox+ �� SelectedItem 6A   �� *WorkingItem.tipoUsuario+$ OneWayToSource=�6�   52      53      �� 54   
    �� Orientation$ 
Horizontal=�6   .+�55      �� $��Regresar��6   $��	350,0,0,0q�6O   $	��100��6b   ��6(   �� *BackToLoginCommand+6b   �� 56      $��Registrarse��6   $	��100��6J   $��20,0,0,0q�6V   ��6+   �� *
AddCommand+6V   58      59      5:      