   M S B A M L   `   `   `  ����@  <Task1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Task1Task1  5   	       Task1.SqlWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Task1     5   	     � Title$  	SqlWindow��5   	   $	��450��6   $	��800��6(   .��5	      �� .+�5
   
   �� $��Укажите цену��6   �� 5   
   -   5         ��Name$ priceTextBox��5      �� 5   
   -   5         ��Name$ getCountBooksButton��5      $!��Количесво книг��6.   6G   �� 5   
   $B��<Укажите запрос на вставку данных��6   �� 5   
   -   5        $ commandTextBox��5      �� 5   
   -   5        $# executeSqlCommandInsertButton��5      $%��Выполнить запрос��68   6S   �� 5   
   $��Укажите цену��6   �� 5   
   -   5        $ priceFilterTextBox��5      �� 5   
   $��Укажите жанр��6   �� 5   
   -   5        $ genreTextBox��5      �� 5   
   -   5        $$ getBooksLessPriceByGenreButton��5      $#��Вывести таблицу��69   6S   �� 5   
   -   5        $ UpdateBookById��5      $#��Изменить данные��6)   6C   &   System.Windows.Controls.DataGrid  5   
   -	   5          Name$ contentDataGrid��5      5      5      