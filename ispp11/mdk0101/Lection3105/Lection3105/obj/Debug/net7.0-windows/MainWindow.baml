   M S B A M L   `   `   `  ����F  BLection3105, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Lection3105Lection3105  5   	       Lection3105.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Lection3105     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	       �� 
TargetType   ButtonTemplate ��Name �� CornerRadius �� Triggers P� Property P� Value �� 
TargetName	 �� Property
 �� Value  ToggleButtonTemplate��%  &	        &	 �    �� 5
   
   " ��6   .R�5      �� $ buttonBorder��6   
���/���$ 10��6D   ._�5      �� #��z��6!   #��z��6E   #��z��6�   5       5      P� 5       �@J�IsMouseOver$
 true��61   . �5      �� $ buttonBorder��6   	 � ��

 � � �6M   5      P� 5       � {�$ false��6/   . �5      �� $ buttonBorder��6   	 � ��

 � ���6M   �� 5      	 � ��

 �����63   5      5      �� 5   
   " d�6   .R�5      �� $ buttonBorder��6   
���/���$ 10��6D   ._�5      �� #��z��6!   #��z��6E   #��z��6�   5       5      P� 5       �@J�IsMouseOver$
 true��61   . �5      �� $ buttonBorder��6   	 � ��

 � � �6M   5      P� 5        �@d�	IsChecked$
 trueY�6/   . �5!      �� $ buttonBorder��6   	 � ��

 �  ��6M   5"      P� 5#       � {�$ false��6/   . �5$      �� $ buttonBorder��6   	 � ��

 � ���6M   �� 5%      	 � ��

 �����63   5&      5(      5)      .��5*      �� .+�5+   
   #   Lection3105.NavigationButtons  -   5          Name$ 
NavButtons��5+   p   #   Lection3105.NavigationButtons   	GoToFirst$! NavigationButtons_GoToFirst��6"      GoToLast$  NavigationButtons_GoToLast��6J   6p   !   Lection3105.PlaceholderText  5,   
   �� 5-   
   ��6   ��  �� ElementName$ 
NavButtons�� �� Path$ CurrentPage��� 5.   
   $	��123��6   �� 5/   
   $	��456��6   #��[  6   $��50��6J   $	��150��6V   �� 50   
   $	��789��6   #��[  6   ${�False��6J   $��50��6\   $	��150��6h   d� 51   
   $	��123��6   #��[ 6%   52      53      