   M S B A M L   `   `   `  ����D  @Att_Check, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Att_Check	Att_Check  5   	       Att_Check.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Att_Check     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ btn_add��5
      $
��Left=�6"   $	��Top=�6=   $	��176��6U   $��101,159,0,0q�6a   $��30��6v   $	��Add��6�   �� 5   
   -   5         ��Name$ userList��5      $
��Left=�6$   $	��274��6?   $��
307,23,0,0q�6L   $	��Top=�6`   $	��331��6x   ��5      �� 5      .R�5      �� .+�5      �� ��6$   �� *Name+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=��� 5      ��6$   �� *Gender+�� 5       d� 	IsChecked 6#   �� *
IsAttended+$ Explicit=�$ TwoWay=�5      5      5      �� 5   
   -   5         ��Name$ userName��5      $
��Left=�6$   $��45��6?   $��
101,23,0,0q�6K    �� TextWrapping$
 Wrap=�6_   $��이름입력��6s   $	��Top=�6   $	��176��6�   �� 5   
   -   5         ��Name$ gender��5      $
��Left=�6#   $��53��6>   $��
101,87,0,0q�6J   $	��Top=�6^   $	��176��6v   	 �� SelectedIndex$	 0��6�   .@�5      �� $��남자��6   �� 5      $��여자��6   5      �� 5   
   -   5        $ btn_del��5      $��Delete��6"   $
��Left=�63   $	��Top=�6N   $	��176��6f   $��101,194,0,0q�6r   $��30��6�   6�   �� 5   
   -   5        $ 	btn_check��5      $��출석��6$   $
��Left=�61   $��59��6L   $��101,238,0,0q�6X   $	��Top=�6m   $	��176��6�   6�   5      5      