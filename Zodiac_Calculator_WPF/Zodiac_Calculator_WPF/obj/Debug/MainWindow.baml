   M S B A M L   `   `   `  ����P  LZodiac_Calculator_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ZodiacCalculatorZodiacCalculator  5   	   &     Zodiac_Calculator_WPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:ZodiacCalculator     5   	   -   5          � Title$  Zodiac Calculator��5   	   $	��350��6#   $	��525��60    � WindowStyle$ ThreeDBorderWindow=�5	       ���	#FFCB7575���	#FFFBFBFD$��Snap ITC)�6o   $��18(�6�   .��5
      � -   5         �Name$ MyWindow��5
      $��	0,0,-84,0q�6    � ColumnDefinitions 5   
   �� 5      $	��88* �6   �� 5      $
��132* �6   �� 5      $	��24* �6   �� 5      $
��211* �6   �� 5      $
��112* �6   �� 5      $	��34* �6   .+�5   
   �� -   5         ��Name$ YearBox��5      $��Please Enter an Year :��6!   $
��Left=�6B   $��38��6]   $��	18,18,0,0q�6i   $	��Top=�6}   $	��205��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   $��3��6�   $��Segoe UI Black)�6�   $��14(�6�   z�5      V� 5      -   5        	ZodiaCalc��.~�5      �� �� 5      �� 5       �� Angle$ -0.217Q�6&   T� 5      5      5      �� 5   
   -   5         ��Name$ 	yearInput��5      $
��Left=�6%   $��42��6@   $��	10,28,0,0q�6L    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��234��6�   $ 
0.53,0.768&�6�   $��2��6�   ���	#FFF0ECEC$��3��6�   �� 5   
   -   5        $��Click to Calculate��5      $��2��6.   $
��Left=�6>   $��	10,91,0,0q�6Y   $	��Top=�6l   $	��234��6�   $��34��6�   $��3��6�   $��Segoe UI Black)�6�   $��16(�6�   	 J� Effect	 5      3  -System.Windows.Media.Effects.DropShadowEffect  5       5"      �� 5#   
   -   5        
 ��Name$
 
indexImage��5#      $��1��6$   $
��Left=�64   $	��150��6O   $��
76,159,0,0q�6\   $	��Top=�6p   $	��260��6�   $��Resources/calc.png��6�   $��3��6�   5%      5&      