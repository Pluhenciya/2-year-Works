   M S B A M L   `   `   `  ����F  BLection0106, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Lection0106Lection0106  5   	       Lection0106.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Lection0106     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � DataContext 5	        Lection0106.Product  5
   
    � 	Resources 5         
windowFont    Lection0106.PriceConverter  priceConverter,   &Lection0106.PriceToBackgroundConverter  priceToBackgroundConverter,   &Lection0106.PriceToDecorationConverter  priceToDecorationConverter �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value	 �� RelativeSource
 �� Mode �� Path��%�  &	        &	      &	 2     &	 E     '�� X     *�5   
   Calibri)�61     5   
   6     5   
   6+     5   
   6+   �� 5   
   " ��6    5      P� 5       �@=�HasError$
 True��69   . �5      ��  �@�ToolTip 60   �� 	 �� $

 Self=�$) #(Validation.Errors)[0].ErrorContent��� 5       � ��
 �  ��63   5      5      5      .��5      �� 
�������.+�5   
   �� $	��100��6   $	��100��6    
���   ���6<   �� *Text+ �� ElementName$ ColorTextBox���� 5   
   -   5         ��Name$ ColorTextBox��5      �� 5   
   -   5        $ 
RedTextBox��5      ��6&   �� *Source+ �� Source# [  6h   �� 5    
   -   5        $ GreenTextBox��5       ��6(   �� *
Background+	 �� $

 Self=� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5!   
   -   5        $ BlueTextBox��5!      6'   �� 5"   
   ��6   �� *Name+ �� TargetNullValue$ 	test name���� 5#   
   ��6   �� *Price+ �� StringFormat$ {0:C}�� �� ConverterCulture$ ru-ru���� 5$   
   ��6   �� *Price+$ Цена: {0} руб.���� 5%   
   ��6   �� *Price+$ {0:0.00}���� 5&   
   ��6   �� *CreationDate+$ {0:dd MM yyyy}���� 5'   
   ��6   �� *CreationDate+$ {0:dd MMMM yyyy}��$ ru-ru���� 5(   
   ��6   �� *PriceString+��61   �� *Price+ �� 	Converter# [ ��5)      �� *Price+# [ �� 5*   
   ��6   �� *Price+# [ �� 5+   
   ��6   �� *Price+$ PropertyChanged=��� 5,   
   -   5        .��5,   5   ��5-      �� 5.      $ Id�6    �� NotifyOnValidationError$
 True��6$    �� ValidationRules 5/      5  /System.Windows.Controls.ExceptionValidationRule  50      5  /System.Windows.Controls.DataErrorValidationRule  51      53      .��54      55      �� 56   
   ��57      �� 58       �� DataType$ local:Product��6   5:      5;      5<      