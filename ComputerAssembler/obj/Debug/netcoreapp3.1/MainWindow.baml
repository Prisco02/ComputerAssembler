   M S B A M L   `   `   `  ����L  HComputerAssembler, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ComputerAssemblerComputerAssembler  5   	   I)clr-namespace:ComputerAssembler.ViewModelComputerAssembler.ViewModel  5   	   ?$clr-namespace:ComputerAssembler.ViewComputerAssembler.View  5   	   "    ComputerAssembler.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:ComputerAssembler     5   	   ?	viewmodel)clr-namespace:ComputerAssembler.ViewModel     5   	   5view$clr-namespace:ComputerAssembler.View     5   	     � WindowStyle$
  None=�5
   	    � Title$ ComputerAssembler��5   	   $	��400��6#   $	��720��60    � 
ResizeMode$ NoResize=�5   	   
������  � AllowsTransparency$
 True��5   	    � 	Resources 5       �� DataType+   %ComputerAssembler.ViewModel.Assembler&    ComputerAssembler.View.Assembler � DataContext+   %ComputerAssembler.ViewModel.Warehouse&    ComputerAssembler.View.Warehouse��%�   (��       5   2   *, +)(�� V     5   2   *, +)�� 5   
   AssemblerTemplate��"  62   .R�5         6   �� 5      �� 5   
   WarehouseTemplate��"  62   .R�5         6   �� 5      5      .��5      �� 
������� �� CornerRadius$ 5��6    ._�5   
   �  � RowDefinitions 5      �� 5      $��30 �6    �� 5      .+�5      �� -   5        
����  �$ 5��5   '   ._�5      � $��0��6   	 � ColumnDefinitions	 5       �� 5!      $��20 �6+   �� 5"      �� 5#      �� 5$      �� 5%      �� 5&      �� 5'      �� 5(      �� 5)      �� 5*      �� 5+      $��20 �6+   �� 5,      $��30 �6+    5.      �� 5/      $��30 �6(   .+�52      �� $��1��6    $��25(�60   $��4��6>   $��ComputerAssembler��6R   $��Bahnschrift SemiBold)�6k   $��0,0,0,1q�6�   $��Stretch=�6�   
�������6�   �� 54      -   5        
 ��Name$
 AssemblerButton��54      $��13(�66   $��6��6D   $��	Assembler��6U   $��Bahnschrift SemiBold)�6i   
���������6�   Z� ��6�   Z� 6�   �� 55      -   5        $
 WarehouseButton��55      $��13(�66   $��7��6D   $��	Warehouse��6U   $��Bahnschrift SemiBold)�6i   
���������6�   Z� ��6�   Z� 6�   �� 56      -   5        $
 GitHubButton��56      $��13(�63   $��8��6A   $��GitHub��6R   $��Bahnschrift SemiBold)�6c   
�������$
��Left=�6�   $��2,0,0,0q�6�   ��6�   Z� ��6�   Z� 6�   �� 59      -   5        $
 MinimizeButton��59      $��10��65   $��-��6F   $��18(�6R   $	��Top=�6`   
�������$��Fira Code Medium)�6�   $
��Left=�6�   $��20��6�   ��6x   Z� ��6�   Z� 6�   �� 5:      -   5        $
 CloseButton��5:      $��11��62   $��x��6C   $��18(�6O   $	��Top=�6]   
�������$��Fira Code Medium)�6�   ��6u   Z� ��6�   Z� 6�   5;      5<      �� 5=      $��0��6   $��1��6-   ��6:   �� 5?      5@      5A      