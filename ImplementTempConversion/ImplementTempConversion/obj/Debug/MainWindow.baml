   M S B A M L   `   `   `  ����R  NImplementTempConversion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:ImplementTempConversionImplementTempConversion  5   	   (    "ImplementTempConversion.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:ImplementTempConversion     5   	   -   5          �Name$  ConversionWindow��5   	    � Title$# Temperature Conversion Window��5   	   $	��350��6/   $	��525��6<    � WindowStyle$ ThreeDBorderWindow=�6H   .��5	      � $��Right=�6    J� OpacityMask 5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6    � Offset$ 0Q�6-   � 5      $ 	#FFC12C2C��6   $ 1Q�61   5      .+�5   
   	� -   5         	�Name$ 	FtoCRadio��5      $��FarenHeitToCelcius��6)   $
��Left=�6F   $��	30,87,0,0q�6a   $	��Top=�6t   	� 5   
   -   5        $ 	CToFRadio��5      $��CelciusToFarenheit��6)   $
��Left=�6F   $��
32,120,0,0q�6a   $	��Top=�6u   �� 5   
   $1��+Type on the Left box and See the Magic...!!��6   $
��Left=�6F   $��
118,32,0,0q�6a   $	��Top=�6u   $��31��6�   $	��255��6�   {�.  $��Segoe UI Black)�6�   �� 5   
   $��Right=�6   $��0,140,10,88q�61   $	��477��6F   	 J� RenderTransformOrigin$	 0.695,0.439&�6R   
 �� Orientation$
 
Horizontal=�6v   .+�5      �� -   5         ��Name$ TextboxInput��5      $��Right=�6,   $��52��6H    �� TextWrapping$
 Wrap=�6T   $��Center=�6h   $	��206��6�   �� 5      -   5        $ TextboxOutput��5      $��54��6-   $
 Wrap=�69   $	��206��6M   $��Center=�6Y   $��40,0,0,1q�6t   {�.  $��Right=�6�   5      �� 5   
   -   5         ��Name$ 
errorLabel��5      $�� ��6$   $
��Left=�6/   $��113,236,0,0q�6J   $	��Top=�6_   $	��260��6w   $��48��6�   $��Cooper Black)�6�   ���	#FFE02D2D6�   5      5      