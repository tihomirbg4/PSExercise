   M S B A M L   `   `   `  ����D  @Expenselt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ExpenseIt	ExpenseIt  5   	       ExpenseIt.ExpenseItHome   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:ExpenseIt     5   	     � Title$  ExpenseIt - Home��5   	   $	��450��6"   $	��800��6/   .��5	      � $��	10,0,10,0q�6   ��5
   
   �� 5       �� ImageSource$ watermark.png��6    � ColumnDefinitions 5   
   �� 5      �� 5      $	��230 �6    � RowDefinitions 5   
   �� 5      �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6   .+�5   
   �� $��1��6x   $��Bottom=�6�   ��6   ��  �� RelativeSource ��  �� AncestorType" � �� Path$ MainCaptionText�6�   �� 5   
   $��1��6   $��1��6!   $��35��6.    �� Padding$ 5q�6:   ���#4E87D4._�5      �� $��Center=�6   
�������.��6B   Names6I   5      �� 5   
   $��0��6   $��2��6"   ��6/   �� $ PersonsChecked�6_   �� 5   
   -   5         ��Name$ peopleListBox��5   [   	 �� SelectedIndex$	 0��6I   $��1��6r   $��2��6�   ��5      ��  �� " �$ ExpenseDataSource���5      �� 5      .R�5       �� ��6   �� $
 Name�6<   5!      5#      �� 5$   
   -   5        $��	0,10,0,10q�5$      $��2q�6j   $��1��6v   $��4��6�   $	��125��6�   $��25��6�   $��Right=�6�   ��6$   �� 
 �� ElementName$
 peopleListBox��$ SelectedItem.Name�6�   �� 5%   
   $��0��6   $��3��6    ��6-   �� $ LastChecked�5&      5'      