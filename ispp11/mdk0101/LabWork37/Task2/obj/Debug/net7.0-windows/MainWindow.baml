   M S B A M L   `   `   `  ����@  <Task2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Task2Task2  5   	       Task2.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Task2     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      ]� .+�5
   
   �� $��Bottom=�6   .@�5      �� -   5         ��Name$ StatusTextBlock��5      5      �� 5   
    �� Orientation$ 
Horizontal=�6   $��Bottom=�6.   .+�5      �� -   5         ��Name$ FileTextBox��5      $��10q�6+   $	��100��67   6C   	� 5      -   5         	�Name$ MoreRadioButton��5      $$��Больше или равно��63   $��10q�6N   5      	� 5      -   5        $ LessRadioButton��5      $$��Меньше или равно��63   $��10q�6N   5      	� 5      -   5        $ AllRadioButton��5      $��Все файлы��62   $��10q�6F   5      5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ ResultDataGrid��5         AutoGenerateColumns$ False��6+      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Имя файла��6%   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 68   �� 
 �� Path$

 Name�  5      $ Расширение��6%   	 69   �� $
 	Extension�  5      $ Путь к файлу��6%   	 6;   �� $
 	Directory�  5      $ Размер��6%   	 65   �� $
 Length�  5      $ Дата создания��6%   	 6<   �� $
 CreationTime�  5      $! Дата изменения��6%   	 6=   �� $
 LastAccessTime�5      5       5!      