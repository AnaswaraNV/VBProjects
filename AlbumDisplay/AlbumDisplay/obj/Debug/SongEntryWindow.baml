   M S B A M L   `   `   `  ����G  CAlbumDisplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:AlbumDisplayAlbumDisplay  5   	   "    AlbumDisplay.SongEntryWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:AlbumDisplay     5   	     � Title$  SongEntryWindow��5   	   $	��300��6!   $	��300��6.   ���	#FFEE8C8C.��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��28* �6   �� 5      $	��45* �6   .+�5   
   �� $��	Song Name��6   $��	10,21,5,0q�6$   $	��Top=�67   $��MS Office Symbol Semibold)�6O   $��14(�6v   �� 5   
   $��Singer��6   $
��Left=�6!   $��	10,61,0,0q�6<   $	��Top=�6O   $��92��6g   $��MS Office Symbol Semibold)�6r   $��14(�6�   �� 5   
   $��Director��6   $
��Left=�6#   $��
10,128,0,0q�6>   $	��Top=�6R   $��97��6j   $��MS Office Symbol Semibold)�6u   $��14(�6�   �� 5   
   -   5         ��Name$ SongNameTextBox��5      $
��Left=�6+   $��23��6F   $��0,24,0,0q�6R    �� TextWrapping$
 Wrap=�6d   $	��Top=�6x   $	��146��6�   $��1��6�   ���	#FFD38A9B6�   �� 5   
   -   5        $ SingerTextBox��5      $
��Left=�6)   $��23��6D   $��0,64,0,0q�6P   $
 Wrap=�6b   $	��Top=�6v   $	��146��6�   $��1��6�   ���	#FFD38A9B6�   �� 5   
   -   5        $ DirectorTextBox��5      $
��Left=�6+   $��23��6F   $��	0,129,0,0q�6R   $
 Wrap=�6e   $	��Top=�6y   $	��146��6�   $��1��6�   ���	#FFD38A9B6�   �� 5   
   -   5         ��Name$ ContinueButton��5      $��Continue��6)   $
��Left=�6<   $��
52,174,0,0q�6W   $	��Top=�6k   $��75��6�   $��2��6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      5      �� 5   
   -   5        $ FinishButton��5      $��Finish��6'   $
��Left=�68   $��
71,174,0,0q�6S   $	��Top=�6g   $��75��6   $��1��6�    5        5      5      �� 5   
   -   5         ��Name$ Duration��5      $��Duration��6"   $
��Left=�65   $��	10,95,0,0q�6P   $	��Top=�6c   $��MS Office Symbol Semibold)�6{   $��14(�6�   $��77��6�   �� 5   
   -   5        $ DurationTextBox��5      $��1��6+   $
��Left=�6;   $��23��6V   $��0,99,0,0q�6b   $
 Wrap=�6t   $	��Top=�6�   $	��146��6�   ���	#FFD38A9B6�   5!      5"      