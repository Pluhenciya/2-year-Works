   M S B A M L   `   `   `  ����@  <Task1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Task1Task1  5   	       Task1.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Task1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��5* �6    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��
Логин��6   �� 5   
   $��1��6   $��Пароль��6   �� 5   
   $��3��6   $��О себе��6   �� 5   
   $��2��6   $+��%Потверждение пароля��6   �� 5   
   -   5         ��Name$ LoginTextBox��5      $��1��6)    �� 	MaxLength$ 10��69   G� 5   
   -   5         G�Name$ UserPasswordBox��5      $��1��6/   $��1��6<    G� 	MaxLength$ 10��6L   G� 5   
   -   5        $ СonfirmationPasswordBox��5      $��2��67   $��1��6D   $ 10��6T   �� 5   
   -   5        $ UserInfoTextBox��5      $��3��6+   $��1��68    �� AcceptsReturn$
 True��6H   �� 5   
   -   5         ��Name$ RegistrationButton��5      $��4��6-   $��2��6:   $*��$Зарегистрироваться��6J   6g   (  "System.Windows.Controls.DatePicker  5   
   -   5        	  Name$	 BirthDatePicker��5      $��4��6.   
   DisplayDateStart
 
01.01.19006;   6Y   �� 5    
   -   5         ��Name$ 
BirthLadel��5       $��5��6$   $��0 лет��61   5!      5"      