   M S B A M L   `   `   `  ����J  FOfficeEquipment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:OfficeEquipmentOfficeEquipment  5   	        OfficeEquipment.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:OfficeEquipment     5   	   -   5          � Title$  
MainWindow��5   	   $��1080 ��6   $
��1920��6+    � WindowStartupLocation$ CenterScreen=�5	       � WindowStyle$
 None=�6'    � WindowState$ 	Maximized=�6:   .��5
      � $
��1070��6   $	��Top=�6   $��0,10,0,0q�6.   .+�5      �� -   5        $��SearchField��5      $��25(�6"   $��1647,0,54,0q�60    �� TextWrapping$
 Wrap=�6E   $	��Top=�6Z   $��50��6r   ���	#FFEAEAEA6~   �� 5      -   5        $
��🔍��5      
������ $��25(�61   $��0q�6?   $
��Left=�6S   $��
1866,5,0,0q�6n   $	��Top=�6�   $��40��6�   $��44��6�   6�   &   System.Windows.Controls.DataGrid  5      -   5          Name$ 
DeviceGrid��5   P      CanUserAddRows$ False��6      CanUserDeleteRows$ False��6$      
IsReadOnly$
 True��6>   $��
0,60,0,192q�6d   	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Id��65      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6A   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6   ��  �� Path$ Id�6A     5      $
 Имя��67   $	 100 6D    6   �� $
 Name�6D     5      $
 Поломка��6;   $	 100 6L    6   �� $ Breaking�6L     5      $
 Устройство��67   $	 100 6K    6   �� $
 Type�6K     5      $
 Штрих-код��67   $	 100 6J    6   �� $
 Code�6J     5      $(
 "Детали для ремонта��6:   $	 100 6V    6   �� $ Details�6V   5      �� 5      -   5        $��
Выход��5      $��0q�6   $
��Left=�6/   $��0,7,0,0q�6J   $	��Top=�6[   $��48��6s   $	��110��6   6�   �� 5      $��	0,883,0,0q�6   .@�5      �� $��Заявка��6   .��5      � ���	#FFE5E5E5.+�5        -   5        $ 
SelectGrid��5      $
 True��6$   $��	0,0,177,0q�66   	 5        5   	   $
 Id��68   $ 50 6D    6   �� $ Id�6D     5    	   $
 Имя��6:   $	 100 6G    6   �� $
 Name�6G     5!   	   $
 Поломка��6>   $	 100 6O    6   �� $ Breaking�6O     5"   	   $
 Устройство��6:   $	 100 6N    6   �� $
 Type�6N     5#   	   $
 Штрих-код��6:   $	 100 6M    6   �� $
 Code�6M     5$   	   $(
 "Детали для ремонта��6=   $	 100 6Y    6   �� $ Details�6Y   5'      �� 5(      -   5        $��Добавить��5(      $
��Left=�6!   $��1742,10,0,0q�6<   $	��Top=�6Q   $��32��6i   $��94��6u   6�   �� 5)      -   5        $��Изменить��5)      $
��Left=�6!   $��1742,59,0,0q�6<   $	��Top=�6Q   $��32��6i   $��94��6u   6�   �� 5*      -	   5        $��Удалить��5*      $
��Left=�6    $��1742,109,0,0q�6;   $	��Top=�6Q   $��32��6i   $��94��6u   6�   5+      5-      50      51      52      