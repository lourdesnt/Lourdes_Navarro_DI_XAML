   M S B A M L   `   `   `  ����R  NLourdes_Navarro_DI_XAML, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Lourdes_Navarro_DI_XAMLLourdes_Navarro_DI_XAML  5   	   1    +Lourdes_Navarro_DI_XAML.Formulario_Piscinas   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:Lourdes_Navarro_DI_XAML     5   	     � Title$  Formulario_Piscinas��5   	   $	��350��6%   $	��380��62    � 
ResizeMode$ NoResize=�6>    � 	Resources 5	       �� 
TargetType �� Property �� Value �� CornerRadius � ToolTip �� ElementName	 �� Path��%�  '��       �� 5
   
   " ��6   .�5      ��  � ��$ Center=�62   �� 5       � ��$ 0,2,40,2q�6'   �� 5       �@=�ErrorTemplate 5      �� 5      .R�5      ]� $
��true��6$   .+�5      �� 
���  ��$��right=�66   $��5,0,0,0q�6M   $��20��6^   $��20��6i   $ 10��6u    5      �� $ customAdorner��$8	 2AdornedElement.(Validation.Errors)[0].ErrorContent�._�5   "   �� $��!��6,   $��center=�65   $��center=�6P   $
��Bold"�6m   
�������5   #   5      �� 5      $��customAdorner��68   $��Center=�6M   .v�5   "   �� 
���  ��$��1q�6;   5      5      5      5      5      5      .��5      � .+�5    
   �� $��/form_bg.jpg��6   $��UniformToFill=�6&   6@   �� 5!   
   $��32,37,250,136q�6   .+�5"      �� $��0,0,0,5q�6   $
��Sala��6%   $��23��64   6B   �� 5#      $��Temperatura��6   $��28��6*   68   �� 5$      $��Especies��6   $��27��6'   65   �� 5%      $��Última revisión��6   60   �� 5&      $��Tratamiento��6   6,   5'      �� 5(   
   $	��161��6   $
��Left=�6"   $	��Top=�6=   $	��198��6U   $��
130,37,0,0q�6a   .+�5)      �� -   5        
 ��Name$
 ComboBoxSalas��5)      $��26��6.   $
��Left=�6:   $	��158��6p    �� Text 6U   �� $
	 Sala�6~   �� 5*      -   5         ��Name$ tb_temp��5*      $��26��6�   $	��158��6�   ��6'   �� $	 Temperatura� �� NotifyOnValidationError$
 True�� �� ValidatesOnDataErrors$
 True��6�   �� 5+      -   5        $ tb_esp��5+      $��26��6�   $	��158��6�   ��6&   �� $	 Especies�$
 True��$
 True��6�   (  "System.Windows.Controls.DatePicker  5,      -   5          Name$ dp_revision��5,      $
��Left=�6.   $��26��6�   $	��158��6�      SelectedDate 6I   �� $	 UltimaRevision�$
 True��$
 True��6�   �� 5-      -   5        $ 	tb_tratam��5-      $��26��6�   $	��158��6�   ��6)   �� $	 Tratamiento�$
 True��$
 True��6�   5.      �� 5/   
   -   5        $��
BtnAgregar��5/      $��56,228,243,51q�6#   $��Agregar��6:   
�������
������
������6�   �� 50   
   -   5        $��238,228,56,51q�50      $��Cancelar��6(   
�������
������
������6�   52      53      