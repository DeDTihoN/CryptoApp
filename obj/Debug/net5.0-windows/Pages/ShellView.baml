   M S B A M L   `   `   `  ����D  @CryptoApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:CryptoApp.PagesCryptoApp.Pages  5   	   ;"clr-namespace:CryptoApp.ConvertersCryptoApp.Converters  5   	   ;"clr-namespace:CryptoApp.ConvertersCryptoApp.Converters  5
   R       CryptoApp.Pages.ShellView   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   A =Stylet, Version=1.3.6.0, Culture=neutral, PublicKeyToken=null)s!https://github.com/canton7/Stylet  5   	   )localclr-namespace:CryptoApp.Pages  5   	   3
converters"clr-namespace:CryptoApp.Converters  5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
   	   /local1"clr-namespace:CryptoApp.Converters  6R     � Title$  Stylet Project��5   	   $	��450��6    $	��800��6-      MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � 	Resources 5      #  MaterialDesignThemes.Wpf.Card �� 
TargetType �� Property �� Value6   0CryptoApp.Converters.ChangePercentColorConverter  ChangePercentColorConverter��%q   '        &	 J     �� 5   
   "  6   .�5      ��  � ��
 ����6+   5        5   
   61   5      .��5        $��10q�6   $��10q�6&   ���	#FF3164B7   UniformCornerRadius$ 70Q�6J   .��5   
   �� $
��Auto=�6   .��5G      �� ��6   �� *
Top10Coins+��5H      �� 5I      .R�5K        $��10q�6.   $��10q�6:   $	��500��6G   $	��200��6S   .��5L      �  � ColumnDefinitions 5M   "   �� 5N   &   $
��auto �67   �� 5O   &   $��* �67   	 � RowDefinitions	 5Q   "   �� 5R   &   $
��auto �64   �� 5S   &   $
��auto �64   �� 5T   &   $
��auto �64   �� 5U   &   $
��auto �64   �� 5V   &   $
��auto �64   �� 5W   &   $��* �64   .+�5Y   "   �� 
 �� Orientation$
 
Horizontal=�6-   $��0��6F   $��0��6S   $��2��6c   $��Center=�6w   $��0 0 0 5q�6�   .+�5Z   &   �� �� 5[   *   $��Heavy"�6D   $��24(�6W   �6.   �� *Name+6W    �� 5\   *   $� (��6.   $��24(�68    �� 5]   *   $��SemiBold"�6F   $��24(�6\   �6.   �� *Symbol+6\    �� 5^   *   $�)��6.   $��24(�67   5_   '   �� 5a   &   $��24��6,   $��24��67   $��10 0 0 0q�6C   ��5b   *   �� 5c   .    �� 	UriSource 6:   �� *
ImageUrl+5e   '   5f   #   �� 5g   "   $��
Usd Price:��6,   $��20(�6>   $��0��6L   $��1��6\   $��0 5 0 0q�6i   �� 5h   "   $��20(�6F   $��1��6T   $��1��6d   $
��Left=�6q   $��5 5 0 0q�6�   ��6,   �� *
PriceUsd+6�   �� 5i   "   $!��Price change in last 24hrs:��6,   $��20(�6O   $��0��6]   $��2��6m   $��0 5 0 0q�6z   �� 5j   "   $��20(�6O   $��1��6]   $��2��6m   $
��Left=�6z   $��5 5 0 0q�6�   ��6,   �� *ChangePercent24Hr+��5k   &   �� 5l   *   " ��60   .�5m   .   ��  � �� 6K   �� *ChangePercent24Hr+ �� 	Converter# [ 5n   +   5p   #   �� 5q   "   $��Market cap:��6,   $��20(�6?   $��0��6M   $��3��6]   $��0 5 0 0q�6j   �� 5r   "   $��20(�6J   $��1��6X   $��3��6h   $
��Left=�6u   $��5 5 0 0q�6�   ��6,   �� *MarketCapUsd+6�   �� 5s   "   $��Rank:��6,   $��20(�69   $��0��6G   $��4��6W   $��0 5 0 0q�6d   �� 5t   "   $��20(�6B   $��1��6P   $��4��6`   $
��Left=�6m   $��5 5 0 0q�6�   ��6,   �� *Rank+6�   5u      5v      5w      5y      5z      5{      5|      