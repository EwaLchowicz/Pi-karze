   M S B A M L   `   `   `  ����B  >Players, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:PlayersPlayers  5   	       Players.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Players     5   	   -   5          � Title$  Pilkarze��5   	   $	��450��6   $	��800��6'    � 
ResizeMode$ NoResize=�63   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��99* �6   �� 5      $
��241* �6   �� 5      $
��454* �6    � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��Imię: ��6   $��0��6"   $��0��62   $��20,10,19,19q�6?   �� 5   
   $��
Nazwisko: ��6   $��0��6&   $��1��66   $��20,10,19,19q�6C   �� 5   
   $��Waga: ��6   $��0��6"   $��2��62   $��20,10,19,19q�6@   �� 5   
   $��Wiek: ��6   $��0��6"   $��3��62   $��20,10,19,19q�6@   �� 5    
   -   5         ��Name$ TextBoxFirstName��5       $��Podaj imię��6,   $��1��6>   $��0��6N   $��
10,8,19,19q�6\   6�   �� 5!   
   -   5        $ TextBoxLastName��5!      $��Podaj Nazwisko��6+   $��1��6A   $��1��6Q   $��
10,8,19,19q�6^   6�   �� 5"   
   -   5         ��Name$ ComboBoxAge��5"      $��10,10,19,10q�6(   $��1��6=   $��3��6M    �� SelectedIndex$ 0��6Z   �� 5#   
   -   5         ��Name$ SliderWeight��5#      $��	7,9,41,19q�6'    � Minimum$ 55Q�6:   	 � Maximum$		 100Q�6G   $��1��6U   $��2��6e   
 �� IsSnapToTickEnabled
 .  �� TickFrequency$	 0.1Q�6�   �� 5$   
   $��Center=�6I   $��Center=�6d   $��1��6�   $��198,5,10,18q�6�   $��2��6�   $��24��6�   $��33��6�   ��6   ��  �� Path$ Value� �� ElementName$ SliderWeight��6�   �� 5'   
   -   5         ��Name$ ButtonDodaj��5'      $��Dodaj��6&   $��1��66   $��5��6F   $��15,10,80,10q�6S   6h   �� 5(   
   -   5        $ 
ButtonUsun��5(      $��Usuń��6%   $��1��64   $��6��6D   $��15,10,80,10q�6Q   6f   �� 5)   
   -   5        $ ButtonModyfikuj��5)      $��	Modyfikuj��6*   $��1��6>   $��7��6N   $��15,10,80,10q�6[   6p   �� 5+   
   -	   5         ��Name$ ListboxPlayers��5+      $��2��6*   $��0��6:   $��9��6G   $��	0,8,20,34q�6X   6k   5,      5-      