   M S B A M L   `   `   `  ����B  >WpfApp4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp4WpfApp4  5   	       WpfApp4.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp4     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      ��  � 	Resources 5
   
    �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers ]� 
Conditions �� Property	 �� Value��%�  '��       �� 5      " ��6   .�5      ��  � ��
 � � �6/   �� 5       � �� 5      �� 5      " ��6*   .R�5      �� #��z��6%   $��1q�6O   
���   �._�5      �� $��Center=�6/   $��Center=�6L   5      5      5       5      ]� 5       5      �� 5       �@J�IsMouseOver$
	 True��6?   ./�5      ��  � ��
 �  ��67   �� 5       � ��$	 200(�65   5      5       5!      .+�5"   
   �� $	��123��6   �� 5#   
   $	��456��6   �� 5$   
   $	��789��6   �� 5%   
   $	��123��6   ��5&      �� 5'      " ��6    5(      �� 5)      
 �� Binding
 6&   ��  �� ElementName$ LoginTextBox�� �� Path$ Text.Length� �� Value 36e   .a�5*      ��  � ��
 �  ��6;   5+      5-      5/      �� 50   
   -   5         ��Name$ LoginTextBox��50      $	��123��6   6   �� 51      $	��456��6   �� 52   
   $	��456��6   .��6   ��53      �� 54      " ��6    55      �� 56      
 6&   ��  �� RelativeSource �� *Self+$ Text.Length� 106q   .a�57      ��  � ��
 �  ��6;   �� 58       � ��$	 200(�69   �� 59       � ��
 ��  �6;   5:      5<      .��5=      5>      �� 5?   
   $	��789��6   �� 5@   
   $	��789��6   �� 5A   
   -   5        $ UserTextBox��5A      �� 5B   
   -   5        $ PasswordTextBox��5B      5C      5D      