   M S B A M L   `   `   `  ����@  <Task1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Task1Task1  5   	       Task1.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Task1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �� .+�5
   
   �� $!��Введите запрос��6   �� 5   
   -   5         ��Name$ queryTextBox��5      �� 5   
   -   5         ��Name$ executeButton��5      $%��Выполнить запрос��6(   6C   �� 5   
   -   5        $ executeTableButton��5      $7��1Выполнить запрос в таблицу��6-   6R   �� 5   
   -   5        $ showBookButton��5      $!��Показать книги��6)   6B   �� 5   
   -   5        $ countRowsButton��5      $:��4Количество изменённых строк��6*   6P   �� 5   
   $"��Введите id книги��6   �� 5   
   -   5        $ idBookTextBox��5      �� 5   
   $3��-Введите новую цену книги��6   �� 5   
   -   5        $ newPriceTextBox��5      �� 5   
   -   5        $ updatePriceButton��5      $*��$Изменить цену книги��6,   6J   �� 5   
   -	   5        $ updateDataBaseButton��5      $��Сохранить��6/   6C   &   System.Windows.Controls.DataGrid  5   
   -
   5          Name$ sqlDataGrid��5      $	��100��6(   5      5      