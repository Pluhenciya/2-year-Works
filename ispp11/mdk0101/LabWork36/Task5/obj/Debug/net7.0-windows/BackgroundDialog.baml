   M S B A M L   `   `   `  ����@  <Task5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Task5Task5  5   	       Task5.BackgroundDialog   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Task5     5   	     � Title$  BackgroundDialog��5   	   $	��250��6"   $	��500��6/   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5       � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      .+�5   
   �� $	��Red��6   $��20(�6   $��10q�6-   �� 5   
   $��Green��6   $��20(�6!   $��10q�6/   $��1��6;   �� 5   
   $
��Blue��6   $��20(�6    $��10q�6.   $��2��6:   �� 5   
   -   5         ��Name$ 	RedSlider��5      $��1��6$    � Minimum$ 0Q�64    � Maximum$	 255Q�6@   $��Center=�6N   $	��256��5      $
��Left=�6   68   �� 5   
   -   5        $ GreenSlider��5      $��1��6&   $��1��66   $ 0Q�6C   $	 255Q�6O   $��Center=�6]   $	��256��5      $
��Left=�6   68   �� 5   
   -   5        $ 
BlueSlider��5      $��1��6%   $��2��65   $ 0Q�6B   $	 255Q�6N   $��Center=�6\   $	��256��5      $
��Left=�6   68   �� 5   
   $��1��6   $��3��6%    �� Orientation$ 
Horizontal=�62   $	��Top=�6K   .+�5      �� -   5         ��Name$ OkButton��5      $��OK��6'   $	��100��64   $��10q�6@   $��20(�6L    �� 	IsDefault$
 True��6Z   5       �� 5!      $��Отмена��6   $	��100��6&   $��10q�62   $��20(�6>   	 �� IsCancel$
	 True��6L   5"      �� 5#   
   $��10q�6   $��2��6   $��3��6-   
���   �$��1q�6R   ._�5$      �� -   5        
 ��Name$
 ColorRectangle��5$      $��2��60   $��3��6@   
���   �6Q   5%      5'      5(      