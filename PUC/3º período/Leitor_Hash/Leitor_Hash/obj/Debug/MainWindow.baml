   M S B A M L   `   `   `  ����F  BLeitor_Hash, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Leitor_HashLeitor_Hash  5   	       Leitor_Hash.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Leitor_Hash     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5   	    � 
ResizeMode$ CanMinimize=�5	   	    � Title$ Reserva de passageiros��5
   	   $��524.195��6(   $��620.227��69   .��5      � .+�5   
   �� -   5         ��Name$ listpassageiros��5      $
��Left=�6,   $	��376��6G   $��	9,110,0,0q�6T   $	��Top=�6g   $	��527��6    �� View 5      �� 5      .P�5      �� $��Código��6%    �� Width$ 80��6]    �� DisplayMemberBinding 65   �� *Codigo+6]   �� 5      $
��Nome��6%   $	 150��6Y    63   �� *Nome+6Y   �� 5      $��Reservas��6%   $	 170��67    �� CellTemplate 5      �� 5      .R�5   "   �� $	��150��6L   $��20��6X   ��6+   �� *
Reservas+6X   5      5      5      5      �� 5   
   -   5         ��Name$ 
lblarquivo��5      $"��Selecione o arquivo de texto��6$   $
��Left=�6K   $��7,9,0,0q�6f   $	��Top=�6w   �� 5   
   -   5        	 ��Name$	 txtfile��5      $
��Left=�6#   $��23��6>   $��	12,34,0,0q�6J   
 �� TextWrapping$
 NoWrap=�6]   $�� ��6t   $	��Top=�6|   $	��264��6�   �� 5   
   -   5         ��Name$ btnopen��5      $��Abrir��6"   $
��Left=�62   $��
279,34,0,0q�6M   $	��Top=�6a   $��87��6y   6�   �� 5   
   -   5        $ lblarquivo_Copy��5      $��Pessoas��6)   $
��Left=�6;   $��	12,76,0,0q�6V   $	��Top=�6i   $��64��6�   $��34��6�   9� 5   
   -   5         9�Name$ expander��5      $��	Pesquisar��6%   $
��Left=�68   $��
371,33,0,0q�6S   $	��Top=�6g   $	��225��6   $��72��6�   .��5       �� $��10,4,0,0q�6   .+�5!      �� -   5        $	 	txtsearch��5!      $
��Left=�6a   $��23��6|   $�� ��6�   $	��Top=�6�   $	��152��6�   �� 5"      -	   5        $ btnopen_Copy��5"      $��Abrir��6/   $
��Left=�6?   $	��Top=�6Z   $	��152��6r   6~   5#      5$      5%      5&      