   M S B A M L   `   `   `  ����E  ACar_Rental, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Car_Rental
Car_Rental  5   	       Car_Rental.ShowCarsWindow   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   *localclr-namespace:Car_Rental     5   	     � Title$  Dostepne samochody��5   	   $	��450��6$   $	��800��61    � WindowStartupLocation$ CenterScreen=�6=    � 	Resources 5      &    Car_Rental.BoolToStatusConverter   BoolToStatusConverter��%   &	          5   
   6&   5      .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid     AutoGenerateColumns$ False��60      CanUserAddRows$ False��6L   $��10q�6c      
IsReadOnly$
 True��6o   ��6   �� *Cars+   Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Zdjecie��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ 80 6:   	   CellTemplate	 5      �� 5      .R�5      �� $��60��6=   $��40��6H   ��6$   �� *Image+6H   5      5      0  *System.Windows.Controls.DataGridTextColumn  5      $ Marka��6%   $	 100 6N   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 64   �� *Brand+6N     5      $ Model��6%   $	 120 6N   
 64   �� *Model+6N     5      $ Rok produkcji��6%   $	 100 6U   
 6<   �� *Year+6U     5      $ Rejestracja��6%   $	 120 6[   
 6:   �� *Registration+6[     5      $ 
Dostepnosc��6%   $	 100 6�   
 69   �� *IsAvailable+ �� 	Converter# [  6�     5      $ Serwis��6)   $ 80 69   	 5      �� 5      .R�5      �� -   5        $��Serwis��5   %   66   5      5      5       5!      5"      