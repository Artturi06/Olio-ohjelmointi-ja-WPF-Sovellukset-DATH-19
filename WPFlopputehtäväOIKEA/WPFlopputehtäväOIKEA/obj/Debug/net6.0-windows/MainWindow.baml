   M S B A M L   `   `   `  ����Q  MWPFlopputehtäväOIKEA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:WPFlopputehtäväOIKEA.MVVM.ViewModel%WPFlopputehtäväOIKEA.MVVM.ViewModel  5   	   ?$clr-namespace:WPFlopputehtäväOIKEAWPFlopputehtäväOIKEA  5   	   '    !WPFlopputehtäväOIKEA.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   I	viewModel3clr-namespace:WPFlopputehtäväOIKEA.MVVM.ViewModel     5   	   6local$clr-namespace:WPFlopputehtäväOIKEA     5   	     � Title$  
MainWindow��5	   	   $	��690��6   $	��920��6)    � WindowStyle$
 None=�5
   	    � 
ResizeMode$ NoResize=�5   	   
������  � AllowsTransparency$
 True��5   	    � DataContext 5      9  3WPFlopputehtäväOIKEA.MVVM.ViewModel.MainViewModel  5   
   .��5      �� ���#272537 �� CornerRadius$ 20��5      ._�5   
   �  � ColumnDefinitions 5      �� 5      $	��200 �6#   �� 5       � RowDefinitions 5      �� 5      $��75 �6    �� 5      .+�5"      �� $��Lopputehtävä��6   $��Center=�5#      $
��Left=�5$      
�������$��22(�5&      $��20,0,0,0q�5'      �� 5)      $��1��6   .+�5+      	� $
��Home��6   $��50��5,      
�������$��14(�5.         MenuButtonTheme#��[  5/      	� 51      $��	Discovery��6   $��50��52      
�������$��14(�54      #��[  55      	� 57      $��Featured��6   $��50��58      
�������$��14(�5:      #��[  5;      5=      �� 5@      $	��250��6   $��40��5A      $��Center=�5B      $
��Left=�5C      $��5q�5D      $��1��5E        ModernTextbox#��[ 5F      �� 5I      $��1��6   $��1��5J      $��10q�5K      ��5L      �� *CurrentView+5Q      5U      5V      