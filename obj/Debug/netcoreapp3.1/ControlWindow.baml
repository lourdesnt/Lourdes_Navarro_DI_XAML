   M S B A M L   `   `   `  ����R  NLourdes_Navarro_DI_XAML, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Lourdes_Navarro_DI_XAMLLourdes_Navarro_DI_XAML  5   	   +    %Lourdes_Navarro_DI_XAML.ControlWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:Lourdes_Navarro_DI_XAML     5   	     � Title$  ControlWindow��5   	   $	��480��6   $	��800��6,    � 
ResizeMode$ NoResize=�68   .��5	      � .+�5
   
   �� $��/pool_bg.jpg��6   $��UniformToFill=�6&   $��0q�6>   � 5   
    � RowDefinitions 5      �� 5      $��50 �6    6.   �� 5      $	��300 �6    6/   �� 5      $	��100 �6    6/    � ColumnDefinitions 5      �� 5      $	��200 �6#   61   �� 5      $	��600 �6#   61   .+�5      �� $�� CONTROL DE PISCINAS ��6   $��0��65   $��2��6B   $��24(�6V   $��Center=�6d   $��DemiBold"�6   
����� �
�������$��Center=�6�   6�   &   System.Windows.Controls.DataGrid  5      -   5          Name$ DataGridPiscinas��5   4   $��1��6   $��1��6$      AutoGenerateColumns$ False��6y      
IsReadOnly$
 True��6�   $��Center=�6�   $��Center=�6�   $��Center=�6�   $��Center=�6  $	��230��6%  $	��500��62  ��6N   ��  �� Path$ ListaPiscinas�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$
	 Sala��6)   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 100 6U   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� $
 Sala�6c     5      $	 Temperatura��6)   $	
 100 6c    6>   �� $ Temperatura�6q     5      $	 Especies��6)   $	
 100 6]    6;   �� $ Especies�6k     5      $	 Última revisión��6)   $	
 100 6j    6B   �� $ UltimaRevision�6x     5      $	 Tratamiento��6)   $	
 100 6c    6>   �� $ Tratamiento�6q   5      �� 5      -   5        $��1��5      $��0��6"   $��Agregar��62   $��38��6E   $��75��6Q   $��63,33,62,179q�6s   
�������
������
������6�   �� 5       -   5        $��1��5       $��0��6"   $��	Modificar��62   $��38��6F   $��76��6R   $��62,106,62,106q�6s   
�������
������
������6�   �� 5!      -   5        $��1��5!      $��0��6"   $��Eliminar��62   $��38��6E   $��76��6Q   $��62,175,62,37q�6t   
�������
������
������6�   �� 5"      -   5        $��2��5"      $��2��6"   $��Center=�66   $��Center=�6S   $��47��6{   $��60��6�   
������ 
������ .��5#      �� $��	/home.png��6   $��50��6+   68   5$      5%      5&      5'      