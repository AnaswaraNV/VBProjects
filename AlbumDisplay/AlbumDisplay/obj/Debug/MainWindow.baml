   M S B A M L   `   `   `  ����G  CAlbumDisplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:AlbumDisplayAlbumDisplay  5   	       AlbumDisplay.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:AlbumDisplay     5   	     � Title$  Album Display��5   	   $	��350��6   $	��525��6,   .��5	      � ���	#FFEE8C8C � ColumnDefinitions 5
   
   �� 5      $	��12* �6   �� 5      $	��57* �6   �� 5      $	��89* �6   �� 5      $
��359* �6   .+�5   
   �� $��Album Display Application��6   $
��Left=�64   $��10,0,0,0q�6O   $	��Top=�6a   $	��353��6y   $��2��6�   $��Rockwell Extra Bold)�6�   $��20(�6�   $��2��6�   �� 5   
   $��Album Title��6   $
��Left=�6&   $��	17,45,0,0q�6A   $	��Top=�6T   $��3��6l   $	��135��6�   $��1��6�   $��MS Office Symbol Semibold)�6�   $��14(�6�   �� 5   
   $��Album Genre��6   $
��Left=�6&   $��	17,91,0,0q�6A   $	��Top=�6T   $��3��6l   $	��135��6�   $��1��6�   $��MS Office Symbol Semibold)�6�   $��14(�6�   �� 5   
   $��Artist��6   $
��Left=�6!   $��
17,141,0,0q�6<   $	��Top=�6P   $��3��6h   $	��148��6|   $��1��6�   $��MS Office Symbol Semibold)�6�   $��14(�6�   �� 5   
   -   5         ��Name$ AlbumTitleTextBox��5      $��3��6-   $
��Left=�6=   $��23��6X   $��101.963,47,0,0q�6d    �� TextWrapping$
 Wrap=�6|   $	��Top=�6�   $	��148��6�   ���	#FFD38A9B6�   �� 5   
   -   5        $ AlbumGenreTextBox��5      $��3��6-   $
��Left=�6=   $��23��6X   $��101.963,93,0,0q�6d   $
 Wrap=�6|   $	��Top=�6�   $	��148��6�   ���	#FFD38A9B6�   �� 5   
   -   5        $ ArtistTextBox��5      $��3��6)   $
��Left=�69   $��23��6T   $��101.963,142,0,0q�6`   $
 Wrap=�6y   $	��Top=�6�   $	��148��6�   ���	#FFD38A9B6�   �� 5   
   $��Release Date��6   $��17,191,353,0q�6'   $	��Top=�6=   $��3��6U   $��1��6i   $��MS Office Symbol Semibold)�6y   $��14(�6�   �� 5   
   -   5        $ ReleaseDateTextBox��5      $��3��6.   $
��Left=�6>   $��23��6Y   $��101.963,192,0,0q�6e   $
 Wrap=�6~   $	��Top=�6�   $	��148��6�   ���	#FFD38A9B6�   �� 5   
   -   5        $
��Next��5      $��3��6    $
��Left=�60   $��61.963,270,0,0q�6K   $	��Top=�6c   $��75��6{    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      5      5      5       