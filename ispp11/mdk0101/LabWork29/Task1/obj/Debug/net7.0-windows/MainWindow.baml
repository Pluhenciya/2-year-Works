   M S B A M L   `   `   `  ����@  <Task1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Task1Task1  5   	       Task1.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Task1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �� .+�5
   
   �  � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5       � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5      �� $��
Логин��6   �� 5      $��1��6    �� Orientation$ 
Horizontal=�6)   .+�5      �� -   5         ��Name$ LoginTextBox��5   &   $	��397��6   6&   �� 5      $A��;Поле обязательно для заполнения��6   $��10(�6B   
���  ����5      �� 5       �� 
TargetType" ��6    .�5   "   ��  �� Property � y� �� Value$ Hidden=�6?    �� Triggers 5   "   �� 5   &   	 �� Binding	 62   �� 
 �� ElementName$
 LoginTextBox�� �� Path$ Text.Length� �� Value 06q   .a�5    *   ��  � y�$ Visible=�6G   5!   '   5#      5%      5&      �� 5(      $��Пароль��6   $��1��6%   �� 5)      $��1��6   $��1��6&   $��10,10,186,10q�63   �� 5<      $��2��6   $��1��6&   .+�5=      �� -   5         ��Name$ ApprovalCheckBox��5=      $G��AСогласен с условиями использования��66   �� 5>      -   5        $ ReadCheckBox��5>      $'��!Прочел соглашение��62   5?      �� 5@      $��1��6   $��3��6*   $ 
Horizontal=�67   .+�5A      �� $*��$Зарегистрироваться��6   ��5B      �� 5C      " ��6     �� BasedOn# [B��64   .�5D      ��  � {�$ False��6:    5E      ^� 5F   "    ^� 
Conditions 5G   &   �� 5H   *    �� Binding 64   �� $
 ApprovalCheckBox��$ 	IsChecked� �� Value True6u   �� 5I   *    64   �� $
 ReadCheckBox��$ 	IsChecked� True6q   .0�5K   &   ��  � {�$
 True��6B   5L   #   5N      5P      �� 5R      $��Отмена��6   �� 5S      $��Сменить тему��6   5T      �� 5U      $��3��6   $
��Left=�6!   $��Center=�6<   $��/Images/galaxy.jpg��6W   $	��145��6s   $	��198��6�   5V      5W      5X      