   M S B A M L   `   `   `  ����   
WpfExample    WpfExample.NamesWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  Commanding Demo��$	��250��$	��300��.���  � ColumnDefinitions �� $
��Auto ���  � RowDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto ��� �� $
��Auto �.+��� .��
First Name�� $��1������ *	FirstName+ �� UpdateSourceTrigger$ PropertyChanged=��� $��1��.��	Last Name�� $��1��$��1������ *
LastName+$ PropertyChanged=��� $��2��$��2�� �� Orientation$ 
Horizontal=�$��Right=�.+��� ���� *AddNameCommand+���� *.+.��Add�� .��Remove�� $��3��.��Names�� $��1��$��3��$	��5 0q�
����������� *Names+ �� SelectedItem �� *SelectedName+�� $��2��$��4��.��Info